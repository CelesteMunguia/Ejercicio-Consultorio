using CapaDatos.BaseDatos.Modelos;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPaciente
    {
        private DPaciente dPaciente;
        private DMedico dMedico;
        private DCita dCita;

        public NPaciente()
        {
            dPaciente = new DPaciente();
            dMedico = new DMedico();
            dCita = new DCita();
        }

        public List<MPaciente> TodosLosPacientes()
        {
            return dPaciente.pacientesTodos();
        }
        public List<MPaciente> PacienteActivos()
        {
            return dPaciente.pacientesTodos().Where(c => c.Estado == true).ToList();
        }
       
        public int AgregarPaciente(MPaciente paciente)
        {
            return dPaciente.GuardarUnidades(paciente);
        }
        public int EditarPaciente(MPaciente condiciones)
        {
            return dPaciente.GuardarUnidades(condiciones);
        }
        public int EliminarPaciente(int pacienteId)
        {
            return dPaciente.EliminarPaciente(pacienteId);
        }
        public List<object> obtenerPacienteGrid()
        {
            var paciente = dPaciente.pacientesTodos().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            });
            return paciente.Cast<object>().ToList();
        }
        public List<object> BuscarPacientesGrid()
        {
            var paciente = dPaciente.pacientesTodos().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            });
            return paciente.Cast<object>().ToList();
        }
        public List<object> obtenerPacienteActivosGrid()
        {
            var paciente = dPaciente.pacientesTodos().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            }).Where(c => c.Estado == true);
            return paciente.Cast<object>().ToList();
        }
        public List<object> BuscarPacienteGridactivos()
        {
            var paciente = dPaciente.pacientesTodos().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado
            }).Where(c => c.Estado == true);
            return paciente.Cast<object>().ToList();
        }
    }
}
