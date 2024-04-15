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
    public partial class PMedico : Form
    {
        private NMedico nMedico;
        private NCita nCita;
        public PMedico()
        {
            InitializeComponent();
            nMedico = new NMedico();
            nCita = new NCita();
            CargarDatos();
        }
        void CargarDatos()
        {
            dgMedico.DataSource = nMedico.TodosLosMedicos();
        }
        void LimpiarDatos()
        {
            txtMedicoId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtFecha.Value = DateTime.Now;
            cbEstado.Checked = false;
            errorProvider1.Clear();
        }


        private void PMedico_Load(object sender, EventArgs e)
        {

        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgMedico.DataSource = nMedico.MedicosActivos();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var agregar = false;
            var medicoId = txtMedicoId.Text.ToString();
            var nombres = txtNombres.Text.ToString();
            var apellidos = txtApellidos.Text.ToString();
            if (string.IsNullOrEmpty(medicoId) || string.IsNullOrWhiteSpace(medicoId))
            {
                agregar = true;
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrWhiteSpace(nombres))
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar el codigo");
                return;
            }
            if (string.IsNullOrEmpty(apellidos) || string.IsNullOrWhiteSpace(apellidos))
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar una descripcion");
                return;
            }

            if (agregar)
            {
                nMedico.AgregarMedicos(new MMedico()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dtFecha.Value,
                    Estado = cbEstado.Checked
                });
            }
            else
            {
                nMedico.EditarMedico(new MMedico()
                {
                    MedicoId = int.Parse(medicoId),
                    Nombres = nombres,
                    Apellidos = apellidos,
                    FechaIngreso = dtFecha.Value,
                    Estado = cbEstado.Checked
                });
            }

            CargarDatos();
            LimpiarDatos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var medicoId = txtMedicoId.Text.ToString();
            if (string.IsNullOrEmpty(medicoId) || string.IsNullOrWhiteSpace(medicoId))
            {
                return;
            }
            var CitaAsociado = nCita.TodasCita().Where(c => c.MedicoId == int.Parse(medicoId)).ToList();
            if (CitaAsociado.Count > 0)
            {
                MessageBox.Show("El medico tiene asociadas 'Citas', desvincule para poder eliminar ");
            }
            else
            {
                nMedico.EliminarMedico(int.Parse(medicoId));
                CargarDatos();
                LimpiarDatos();
            }
        }

        private void dgMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgMedico.Rows.Count)
            {
                DataGridViewRow row = dgMedico.Rows[e.RowIndex];
                txtMedicoId.Text = row.Cells["MedicoId"].Value.ToString();
                txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgMedico.CurrentRow.Cells["Estado"].Value.ToString());
                
            }
        }
    } 
}
