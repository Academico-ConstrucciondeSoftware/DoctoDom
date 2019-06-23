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

namespace DoctoDom
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        public User User { get; set; }
        public bool UserDeleted { get; set; }

        private void ChangeColorFormParent()
        {
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    if (ctl is MdiClient)
                    {
                        // Attempt to cast the control to type MdiClient.
                        ctlMDI = (MdiClient)ctl;
                        // Set the BackColor of the MdiClient control.
                        ctlMDI.BackColor = Color.White;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmParent_Load(object sender, EventArgs e)
        {
            ChangeColorFormParent();
            Visible = false;
            Visible = ValidateUser();

            if (User != null && !string.IsNullOrEmpty(User.UserName))
            {
                Text = "Bienvenido " + User.UserName;
            }
        }
      
        private bool ValidateUser()
        {
            frmInitial fInitial = new frmInitial();
            if (fInitial.ShowDialog() == DialogResult.OK)
            {
                fInitial.Visible = false;
                frmLogin fLogin = new frmLogin();
                fLogin.UserType = fInitial.UserType;                
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    User = fLogin.User;
                    fInitial.Close();
                    return true;
                }
            }

            return false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {            
            if (pnMenu.Width == 280)
            {
                pnMenu.Width = 43;
                btnCitas.Text = string.Empty;
                btnPerfil.Text = string.Empty;
            }
            else
            {
                pnMenu.Width = 280;
                btnCitas.Text = btnCitas.Tag.ToString();
                btnPerfil.Text = btnPerfil.Tag.ToString();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Doctor)
            {
                UI.frmPerfilDoc frmPerfilDoc = new UI.frmPerfilDoc();
                frmPerfilDoc.User = User;
                frmPerfilDoc.UserType = User.UserType;
                frmPerfilDoc.WindowState = FormWindowState.Maximized;
                if (frmPerfilDoc.ShowDialog() == DialogResult.OK)
                {
                    UserDeleted = frmPerfilDoc.UserDeleted;
                    if (UserDeleted)
                    {
                        this.frmParent_Load(this, new EventArgs());
                    }
                }
            }

            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Paciente)
            {
                UI.frmPerfilPac frmPerfilPac = new UI.frmPerfilPac();
                frmPerfilPac.User = User;
                frmPerfilPac.UserType = User.UserType;
                frmPerfilPac.WindowState = FormWindowState.Maximized;
                if (frmPerfilPac.ShowDialog() == DialogResult.OK)
                {
                    UserDeleted = frmPerfilPac.UserDeleted;
                    if (UserDeleted)
                    {
                        this.frmParent_Load(this, new EventArgs());
                    }
                }
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Doctor)
            {
                UI.frmCitas frmCitas = new UI.frmCitas();
                frmCitas.User = User;
                frmCitas.WindowState = FormWindowState.Maximized;
                if (frmCitas.ShowDialog() == DialogResult.OK)
                {
                    if (frmCitas.AppointmentDeleted)
                    {
                        this.frmParent_Load(this, new EventArgs());
                    }
                }
            }

            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Paciente)
            {
                UI.frmCitas frmCitas = new UI.frmCitas();
                frmCitas.User = User;
                frmCitas.WindowState = FormWindowState.Maximized;
                if (frmCitas.ShowDialog() == DialogResult.OK)
                {
                    if (frmCitas.AppointmentDeleted)
                    {
                        this.frmParent_Load(this, new EventArgs());
                    }
                }
            }
        }
    }
}
