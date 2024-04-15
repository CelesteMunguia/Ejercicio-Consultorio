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
    public partial class BuscarPaciente : Form
    {
        NPaciente nPaciente;

        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public BuscarPaciente()
        {
            InitializeComponent();
            nPaciente = new NPaciente();
            cargardatos();
        }
        private void cargardatos()
        {
            var datos = nPaciente.BuscarPacientesGrid();
            dgBPa.DataSource = datos;
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void cbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            dgBPa.DataSource = nPaciente.BuscarPacienteGridactivos();
            if (cbFiltrar.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgBPa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PacienteId = Convert.ToInt32(dgBPa.CurrentRow.Cells["PacienteId"].Value);
            Nombres = dgBPa.CurrentRow.Cells["Nombres"].Value.ToString();
            Apellidos = dgBPa.CurrentRow.Cells["Apellidos"].Value.ToString();

            this.Visible = false;
        }
    }
}
