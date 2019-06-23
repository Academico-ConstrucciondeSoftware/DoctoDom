using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctoDom
{
    public partial class frmInitial : Form
    {
        public frmInitial()
        {
            InitializeComponent();
        }

        public int UserType { get; set; }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            UserType = (int)Helpers.UserType.Doctor;
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserType = (int)Helpers.UserType.Paciente;
            DialogResult = DialogResult.OK;
        }

        private void frmInitial_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult = DialogResult.No;
        }
    }
}
