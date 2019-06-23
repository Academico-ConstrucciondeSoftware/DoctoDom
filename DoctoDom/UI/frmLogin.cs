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
using DoctoDom.Models;

namespace DoctoDom
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public int UserType { get; set; }        
        public User User { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UserRule userRule = new UserRule();
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtClave.Text))
            {
                User = userRule.GetUser(txtUsuario.Text, txtClave.Text);
                if (!string.IsNullOrEmpty(User.UserName) && User.UserType == UserType)
                {                    
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El usuario o la clave es incorrecta.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    txtClave.Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Los campos usuario y clave son requeridos para iniciar sesión en el sistema", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UI.frmRegisterUser frmRegisterUser = new UI.frmRegisterUser();
            frmRegisterUser.UserType = UserType;
            frmRegisterUser.Show();            
        }
    }
}
