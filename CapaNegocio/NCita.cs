using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCita
    {
        private DCita dcita;
        private MMedico mMedico;
        private MPaciente mPaciente;

        public NCita()
        {
            dcita = new DCita();
            mMedico = new MMedico();
            mPaciente = new MPaciente();
        }

        public List<MCita> TodasCita()
        {
            return dcita.TodasLasCitas();
        }
        public int AgregarCita(MCita Cita)
        {
            Cita.FechaCita = DateTime.Now;
            return dcita.GuardarCita(Cita);
        }
        public int EditarCita(MCita Cita)
        {
            return dcita.GuardarCita(Cita);
        }
        public int Eliminar(int CitaID)
        {
            return dcita.EliminarCita(CitaID);
        }
        public List<object> obtenerCitaActivosGrid()
        {
            var citas = dcita.TodasLasCitas().Select(c => new {
                c.CitaId,
                Medico = c.MMedico.Nombres,
                Paciente = c.MPaciente.Nombres,
                c.Estado,
                c.FechaCita
            }).Where(c => c.Estado == true);
            return citas.Cast<object>().ToList();
        }
        public List<object> BuscarCitasGrid()
        {
            var cita = dcita.TodasLasCitas().Select(c => new {
                c.CitaId,
                Medico = c.MMedico.Nombres,
                Paciente = c.MPaciente.Nombres,
                c.Estado,
            });
            return cita.Cast<object>().ToList();
        }
        public List<object> BuscarCitasGridactivas()
        {
            var citas = dcita.TodasLasCitas().Select(c => new {
                c.CitaId,
                Medico = c.MMedico.Nombres,
                Paciente = c.MPaciente.Nombres,
                c.Estado,
            }).Where(c => c.Estado == true);
            return citas.Cast<object>().ToList();
        }
    }
}
