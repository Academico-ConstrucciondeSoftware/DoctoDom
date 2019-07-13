using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctoDom.Models;
using DoctoDom.Rules;
using DoctoDom.UI;

namespace DoctoDom.UI
{
    public partial class frmPerfilDoc : Form
    {
        public frmPerfilDoc()
        {
            InitializeComponent();
        }

        public User User { get; set; }
        private UserRule userRule = new UserRule();
        private SpecialtiesRule specialtiesRule = new SpecialtiesRule();

        public int UserType { get; set; }
        public bool UserDeleted { get; set; }

        private void DisableControl(bool enable)
        {
            List<GroupBox> groupBoxes = new List<GroupBox>();
            groupBoxes.Add(gbxDatosGenerales);
            groupBoxes.Add(gbxCredenciales);
            groupBoxes.Add(gbxInfoContacto);
            groupBoxes.Add(gbxEspecialidades);

            foreach (GroupBox groupBox in groupBoxes)
            {
                foreach (Control _ctl in groupBox.Controls)
                {
                    _ctl.Enabled = enable;
                }
            }
        }

        private bool ValidateRequeridControl()
        {
            List<GroupBox> groupBoxes = new List<GroupBox>();
            groupBoxes.Add(gbxDatosGenerales);
            groupBoxes.Add(gbxCredenciales);
            groupBoxes.Add(gbxInfoContacto);

            foreach (GroupBox groupBox in groupBoxes)
            {
                foreach (Control _ctl in groupBox.Controls)
                {
                    if ((_ctl is TextBox || _ctl is DateTimePicker) && _ctl.Tag != null)
                    {
                        if (string.IsNullOrEmpty(_ctl.Text))
                        {
                            MessageBox.Show("El campo " + _ctl.Tag.ToString() + " es requerido.");
                            _ctl.Focus();

                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadUser();            
            DisableControl(false);// Disable all control in this form
            btnGuardar.Visible = false;

            User user = new User(1,"","");
            user = userRule.GetUser(User.Id);
            if (!string.IsNullOrEmpty(user.ImagePath))
            {                
                pbxFoto.Load(@user.ImagePath);
            }
        }

        private void LoadUser()
        {
            User user = new User(1,"","");
            user = userRule.GetUser(User.Id);
            txtCedula.Text = user.Cedula;
            txtNombres.Text = user.UserName;
            txtApellidos.Text = user.LastName;
            dtpFechaNacimiento.Value = user.Birthdate;
            txtUsuario.Text = user.Nickname;
            txtClave.Text = user.UserPassword;
            txtDireccion.Text = user.UserAddres;
            txtTelefono.Text = user.Phone1;
            txtCelular.Text = user.Phone2;
            txtEmail.Text = user.Email;
            User.UserType = UserType;

            if (user.Specialties > 0)
            {
                LoadCombo();                
                cbxEspecialidades.SelectedValue = user.Specialties;                
            }
        }

        private User GetUser()
        {
            User user = new User(1,"","");
            user.Id = User.Id;
            user.UserName = txtNombres.Text;
            user.LastName = txtApellidos.Text;
            user.Cedula = txtCedula.Text;
            user.Birthdate = dtpFechaNacimiento.Value;
            user.Nickname = txtUsuario.Text;
            user.UserPassword = txtClave.Text;
            user.UserAddres = txtDireccion.Text;
            user.Phone1 = txtTelefono.Text;
            user.Phone2 = txtCelular.Text;
            user.Email = txtEmail.Text;
            user.UserType = UserType;
            user.Specialties = Convert.ToInt32(cbxEspecialidades.SelectedIndex + 1);
            user.ImagePath = pbxFoto.ImageLocation ?? string.Empty;
            user.CreatedDate = DateTime.Now;
            return user;
        }

        private void LoadCombo()
        {
            cbxEspecialidades.DataSource = specialtiesRule.GetSpecialties();
            cbxEspecialidades.ValueMember = "Id";
            cbxEspecialidades.DisplayMember = "SpecialtiesName";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            DisableControl(true);// Enable all control in this form
        }

        private void pbxFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    pbxFoto.Load(openFileDialog.FileName);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateRequeridControl())
            {
                int qttRow = userRule.UpdateUser(GetUser());
                if (qttRow > 0)
                {
                    MessageBox.Show("El usuario fue modificado con exito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableControl(false);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que quiere eliminar el usuario?";
            if (MessageBox.Show(this, message,"DoctorDom",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int qttRow = userRule.DeleteUser(GetUser());
                if (qttRow > 0)
                {
                    MessageBox.Show("El usuario fue eliminado con exito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    UserDeleted = true;
                }
            }            
        }
    }
}
