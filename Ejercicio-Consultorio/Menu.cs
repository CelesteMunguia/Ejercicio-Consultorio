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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMedico Medico = new PMedico();
            Medico.MdiParent = this;
            Medico.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PPaciente Paciente = new PPaciente();
            Paciente.MdiParent = this;
            Paciente.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PCita Cita = new PCita();
            Cita.MdiParent = this;
            Cita.Show();
        }
    }
}
