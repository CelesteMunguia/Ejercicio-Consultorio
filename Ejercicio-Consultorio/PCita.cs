using CapaDatos.BaseDatos.Modelos;
using CapaNegocio;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Consultorio
{
    public partial class PCita : Form
    {
        NCita nCita;

        public PCita()
        {
            InitializeComponent();
            nCita = new NCita();
            CargarDatos();
        }
        void CargarDatos()
        {
            var datos = nCita.obtenerCitaActivosGrid();
            dgcita.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtCitaId.Text = "";
            txtMeId.Text = "";
            txtPaciId.Text = "";
            txtNombress.Text = "";
            txtApellidoss.Text = "";
            dtFechaa.Value = DateTime.Now;
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }
        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtNombress.Text.ToString()) || string.IsNullOrWhiteSpace(txtNombress.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtNombress, "Debe de buscar y seleccionar un Nombre");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(txtApellidoss.Text.ToString()) || string.IsNullOrWhiteSpace(txtApellidoss.Text.ToString()))
            {
                FormularioValido = false;
                errorProvider1.SetError(txtApellidoss, "Debe buscar y seleccionar un Apellido");
                return FormularioValido;
            }


            return FormularioValido;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgcita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgcita.Rows.Count)
            {
                DataGridViewRow row = dgcita.Rows[e.RowIndex];
                txtCitaId.Text = row.Cells["CitaId"].Value.ToString();
                txtNombress.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidoss.Text = row.Cells["Apellidos"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgcita.CurrentRow.Cells["Estado"].Value.ToString());

            }
        }

        private void PCita_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarr_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MCita Cita = new MCita()
                {
                    MedicoId = int.Parse(txtCitaId.Text.ToString()),
                    PacienteId = int.Parse(txtCitaId.Text.ToString()),
                    FechaCita = dtFechaa.Value,

                };
                if (!string.IsNullOrEmpty(txtCitaId.Text) && int.TryParse(txtCitaId.Text.ToString(), out int citaId) && citaId != 0)
                {
                    Cita.CitaId = citaId;
                    nCita.EditarCita(Cita);

                }
                else
                {
                    nCita.AgregarCita(Cita);
                }
                LimpiarDatos();
                CargarDatos();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBMedic_Click(object sender, EventArgs e)
        {
            BuscarMedico BuscarMedico = new BuscarMedico();
            BuscarMedico.ShowDialog();
            txtMeId.Text = BuscarMedico.MedicoId.ToString();
            txtNombress.Text = BuscarMedico.Nombres.ToString();
            txtApellidoss.Text = BuscarMedico.Apellidos.ToString();
        }

        private void btnBPaci_Click(object sender, EventArgs e)
        {
            BuscarPaciente BuscarPaciente = new BuscarPaciente();
            BuscarPaciente.ShowDialog();
            txtPaciId.Text = BuscarPaciente.PacienteId.ToString();
            txtNombress.Text = BuscarPaciente.Nombres.ToString();
            txtApellidoss.Text = BuscarPaciente.Apellidos.ToString();
        }

        private void btnEliminarr_Click(object sender, EventArgs e)
        {
            var citaId = txtCitaId.Text.ToString();
            if (string.IsNullOrEmpty(citaId) || string.IsNullOrWhiteSpace(citaId))
            {
                return;
            }
            nCita.Eliminar(int.Parse(citaId));
            CargarDatos();
            LimpiarDatos();
        }
}   }
