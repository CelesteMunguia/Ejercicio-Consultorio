using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NMedico
    {
        private DMedico dMedico;
        private DPaciente dPaciente;
        private DCita dCita;

        public NMedico()
        {
            dMedico = new DMedico();
            dPaciente = new DPaciente();
            dCita = new DCita();
        }

        public List<MMedico> TodosLosMedicos()
        {
            return dMedico.medicoTodos();
        }
        public List<MMedico> MedicosActivos()
        {
            return dMedico.medicoTodos().Where(c => c.Estado == true).ToList();
        }
        public int AgregarMedicos(MMedico medico)
        {
            return dMedico.GuardarUnidades(medico);
        }
        public int EditarMedico(MMedico condiciones)
        {
            return dMedico.GuardarUnidades(condiciones);
        }
        public int EliminarMedico(int medicoId)
        {
            return dMedico.EliminarMedico(medicoId);
        }
        public List<object> obtenerMedicoGrid()
        {
            var medico = dMedico.medicoTodos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            });
            return medico.Cast<object>().ToList();
        }
        public List<object> BuscarMedicosGrid()
        {
            var medicos = dMedico.medicoTodos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            });
            return medicos.Cast<object>().ToList();
        }
        public List<object> obtenerMedicosActivosGrid()
        {
            var medico = dMedico.medicoTodos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            }).Where(c => c.Estado == true);
            return medico.Cast<object>().ToList();
        }
        public List<object> BuscarMedicoGridactivos()
        {
            var medico = dMedico.medicoTodos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            }).Where(c => c.Estado == true);
            return medico.Cast<object>().ToList();
        }

    }
}
