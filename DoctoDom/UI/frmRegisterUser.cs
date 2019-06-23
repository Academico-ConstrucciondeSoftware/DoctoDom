using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctoDom.Rules;
using DoctoDom.Helpers;
using DoctoDom.Models;

namespace DoctoDom.UI
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private UserRule userRule = new UserRule();
        public int FormOpenMode { get; set; }
        public int UserType { get; set; }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
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

        private User GetUser()
        {
            User user = new User();            
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
            user.Specialties = 0;
            user.ImagePath = pbxFoto.ImageLocation ?? string.Empty;
            user.CreatedDate = DateTime.Now;            
            return user;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateRequeridControl())
            {
                int qttRow = userRule.NewUser(GetUser());
                if (qttRow > 0)
                {
                    MessageBox.Show("El usuario fue registrado con exito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    Close();
                }
            }
        }
    }
}
