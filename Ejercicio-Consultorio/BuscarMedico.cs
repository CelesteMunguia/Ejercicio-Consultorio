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
    public partial class BuscarMedico : Form
    {
        NMedico nMedico;

        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        
        public BuscarMedico()
        {
            InitializeComponent();
            nMedico = new NMedico();
            cargardatos();
        }
        private void cargardatos()
        {
            var datos = nMedico.BuscarMedicosGrid();
            dgMedic.DataSource = datos;
        }

        private void BuscarMedico_Load(object sender, EventArgs e)
        {

        }

        private void cbFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            dgMedic.DataSource = nMedico.BuscarMedicoGridactivos();
            if (cbFiltrar.Checked == false)
            {
                cargardatos();
            }
        }

        private void dgMedic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicoId = Convert.ToInt32(dgMedic.CurrentRow.Cells["MedicoId"].Value);
            Nombres = dgMedic.CurrentRow.Cells["Nombres"].Value.ToString();
            Apellidos = dgMedic.CurrentRow.Cells["Apellidos"].Value.ToString();
            
            this.Visible = false;
        }
    }
}
