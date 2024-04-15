using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocio;
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
    public partial class PPaciente : Form
    {
        private NPaciente nPaciente;
        private NCita nCita;
        public PPaciente()
        {
            InitializeComponent();
            nPaciente = new NPaciente();
            nCita = new NCita();
            CargarDatos();
        }
        void CargarDatos()
        {
            dgPaciente.DataSource = nPaciente.TodosLosPacientes();
        }
        void LimpiarDatos()
        {
            txtPacienteId.Text = "";
            txtNombres2.Text = "";
            txtApellidos2.Text = "";
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }

        private void dgPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgPaciente.Rows.Count)
            {
                DataGridViewRow row = dgPaciente.Rows[e.RowIndex];
                txtPacienteId.Text = row.Cells["PacienteId"].Value.ToString();
                txtNombres2.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos2.Text = row.Cells["Apellidos"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgPaciente.CurrentRow.Cells["Estado"].Value.ToString());

            }
        }

     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var pacienteId = txtPacienteId.Text.ToString();
            var nombres2 = txtNombres2.Text.ToString();
            var apellidos2 = txtApellidos2.Text.ToString();
            if (string.IsNullOrEmpty(pacienteId) || string.IsNullOrWhiteSpace(pacienteId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombres2) || string.IsNullOrWhiteSpace(nombres2))
            {
                errorProvider1.SetError(txtNombres2, "Debe ingresar el codigo");
                return;
            }
            if (string.IsNullOrEmpty(apellidos2) || string.IsNullOrWhiteSpace(apellidos2))
            {
                errorProvider1.SetError(txtApellidos2, "Debe ingresar una descripcion");
                return;
            }

            if (agregar)
            {
                nPaciente.AgregarPaciente(new MPaciente()
                {
                    Nombres = nombres2,
                    Apellidos = apellidos2,
                    FechaIngreso = dtfecha.Value,
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nPaciente.EditarPaciente(new MPaciente()
                {
                    PacienteId = int.Parse(pacienteId),
                    Nombres = nombres2,
                    Apellidos = apellidos2,
                    FechaIngreso = dtfecha.Value,
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var pacienteId = txtPacienteId.Text.ToString();
            if (string.IsNullOrEmpty(pacienteId) || string.IsNullOrWhiteSpace(pacienteId))
            {
                return;
            }
            var CitaAsociado = nCita.TodasCita().Where(c => c.PacienteId == int.Parse(pacienteId)).ToList();
            if (CitaAsociado.Count > 0)
            {
                MessageBox.Show("El paciente tiene asociadas 'Citas', desvincule para poder eliminar ");
            }
            else
            {
                nPaciente.EliminarPaciente(int.Parse(pacienteId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void cbActivas_CheckedChanged(object sender, EventArgs e)
        {
            dgPaciente.DataSource = nPaciente.TodosLosPacientes();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void PPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
