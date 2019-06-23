using DoctoDom.Models;
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

namespace DoctoDom.UI
{
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        public User User { get; set; }
        public bool AppointmentDeleted { get; set; }
        private AppointmentsRule appointmentsRule = new AppointmentsRule();
        public Quotes Quote { get; set; }
        public int QuoteT { get; set; }
        public bool ViewDetail { get; set; }
        public Helpers.Operation Operation;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            gbxServicio.Visible = false;
            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Paciente)
            {
                gbxServicio.Visible = true;
            }
            else
            {
                btnCitas.Visible = false;
                btnModificar.Visible = false;
                btnGuardar.Visible = false;                
            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void ConfigurateGrid()
        {
            dgvDatos.Columns["Id"].Width = 50;
            dgvDatos.Columns["Id"].HeaderText = "No Cita";

            dgvDatos.Columns["QuotesDescription"].Width = 500;
            dgvDatos.Columns["QuotesDescription"].HeaderText = "Descripcion";

            dgvDatos.Columns["QuotesDate"].Width = 160;
            dgvDatos.Columns["QuotesDate"].HeaderText = "Fecha";

            dgvDatos.Columns["Specialties"].Width = 220;
            dgvDatos.Columns["Specialties"].HeaderText = "Especialidad";
            dgvDatos.Columns["Specialties"].Visible = false;
            dgvDatos.Columns["UserId"].Visible = false;

        }

        private void LoadAppointments()
        {
            DataTable dataTable = new DataTable();

            if((Helpers.UserType)User.UserType == Helpers.UserType.Paciente)
                dataTable = appointmentsRule.GetAppointments(User.Id);
            else
                dataTable = appointmentsRule.GetAppointmentsDoctor(User.Id);

            if (dataTable.Rows.Count > 0)
            {
                dgvDatos.DataSource = dataTable;
                ConfigurateGrid();
            }

            txtBuscar.Focus();
        }

        public void LoadDetailAppointments(int UserId, int CitaId)
        {
            DisableControl(false);
            Quotes quotes = new Quotes();
            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Paciente)
                quotes = appointmentsRule.GetDetailtAppointments(UserId, CitaId);
            else
                quotes = appointmentsRule.GetDetailtAppointmentsDoctor(UserId, CitaId);

            if (!string.IsNullOrEmpty(quotes.Id.ToString()))
            {
                txtId.Text = quotes.Id.ToString();
                txtDescripcion.Text = quotes.QuotesDescription;
                dtpFecha.Value = quotes.QuotesDate;
                cbxDoctor.SelectedValue = quotes.UserId;
                cbxEspecialidad.SelectedValue = quotes.Specialties;
                cbxDoctor.SelectedValue = quotes.DoctorId;
                ConfigurateGrid();
            }

            txtBuscar.Focus();
        }

        private void LoadDoctores()
        {
            UserRule userRule = new UserRule();
            cbxDoctor.DataSource = userRule.GetDoctor();
            cbxDoctor.ValueMember = "Id";
            cbxDoctor.DisplayMember = "UserName";
        }

        private void LoadEspecialidades()
        {
            SpecialtiesRule specialtiesRule = new SpecialtiesRule();
            cbxEspecialidad.DataSource = specialtiesRule.GetSpecialties();
            cbxEspecialidad.ValueMember = "Id";
            cbxEspecialidad.DisplayMember = "SpecialtiesName";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                DataTable dataTable = new DataTable();
                dataTable = appointmentsRule.GetAppointments(User.Id, txtBuscar.Text);
                if (dataTable.Rows.Count > 0)
                {
                    dgvDatos.DataSource = dataTable;
                    ConfigurateGrid();
                    return;
                }
            }
            LoadAppointments();
        }

        private void DisableControl(bool enable)
        {
            List<GroupBox> groupBoxes = new List<GroupBox>();
            groupBoxes.Add(gbxInfoGeneral);
            groupBoxes.Add(gbxServicio);

            foreach (GroupBox groupBox in groupBoxes)
            {
                foreach (Control _ctl in groupBox.Controls)
                {
                    _ctl.Enabled = enable;
                }
            }
        }

        private void tabDetalle_Enter(object sender, EventArgs e)
        {
            if (Operation == Helpers.Operation.CREATE)
            {
                DisableControl(true);
            }

            LoadDoctores();
            LoadEspecialidades();
            if (dgvDatos.Rows.Count > 0)
            {
                LoadDetailAppointments(User.Id, Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value));
            }
        }

        public Quotes GetQuote()
        {
            Quotes quote = new Quotes();
            quote.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            quote.QuotesDate = dtpFecha.Value;
            quote.QuotesDescription = txtDescripcion.Text;
            quote.DoctorId = Convert.ToInt32(cbxDoctor.SelectedValue);
            quote.Specialties = Convert.ToInt32(cbxEspecialidad.SelectedValue);
            quote.UserId = User.Id;
            return quote;
        }

        private void tabListado_Enter(object sender, EventArgs e)
        {
            frmCitas_Load(this, new EventArgs());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (((Helpers.UserType)User.UserType) == Helpers.UserType.Paciente)
            {
                AppointmentsRule appointmentsRule = new AppointmentsRule();
                if (Operation == Helpers.Operation.CREATE)
                {
                    int qtt = appointmentsRule.NewAppointment(GetQuote());
                    if (qtt > 0)
                    {
                        MessageBox.Show("Su cita fue registrada con exito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else if (Operation == Helpers.Operation.EDIT)
                {
                    int qtt = appointmentsRule.EditAppointment(GetQuote());
                    if (qtt > 0)
                    {
                        MessageBox.Show("Su cita fue modificada con exito.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
        }

        public void LimpiarControles()
        {
            foreach (Control _ctl in gbxInfoGeneral.Controls)
            {
                if (_ctl is TextBox)
                {
                    _ctl.Text = string.Empty;
                }
            }

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {           
            Operation = Helpers.Operation.CREATE;
            tabControl.SelectedTab = tabDetalle;
            LimpiarControles();
            DisableControl(true);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Operation = Helpers.Operation.EDIT;
            tabControl.SelectedTab = tabDetalle;
            DisableControl(true);
        }
    }
}
