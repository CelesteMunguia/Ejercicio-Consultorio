using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPaciente
    {
        UnitOfWork _unitOfWork;

        public DPaciente()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }


        public List<MPaciente> pacientesTodos()
        {
            return _unitOfWork.Repository<MPaciente>().Consulta().ToList();
        }

        public int GuardarUnidades(MPaciente paciente)
        {

            if (paciente.PacienteId == 0)
            {
                _unitOfWork.Repository<MPaciente>().Agregar(paciente);
                return _unitOfWork.Guardar();
            }
            else
            {
                var PacienteInDb = _unitOfWork.Repository<MPaciente>().Consulta().FirstOrDefault(c => c.PacienteId == paciente.PacienteId);

                if (PacienteInDb != null)
                {
                    PacienteInDb.Nombres = paciente.Nombres;
                    PacienteInDb.Apellidos = paciente.Apellidos;
                    PacienteInDb.Estado = paciente.Estado;
                    PacienteInDb.FechaIngreso = paciente.FechaIngreso;
                    _unitOfWork.Repository<MPaciente>().Editar(PacienteInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarPaciente(int pacienteId)
        {
            var PacienteInDb = _unitOfWork.Repository<MPaciente>().Consulta().FirstOrDefault(c => c.PacienteId == pacienteId);
            if (PacienteInDb != null)
            {
                _unitOfWork.Repository<MPaciente>().Eliminar(PacienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

       
    }
}
