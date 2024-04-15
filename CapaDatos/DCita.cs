using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCita
    {
        UnitOfWork _unitOfWork;

        public DCita()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }
       

        public List<MCita> TodasLasCitas()
        {
            return _unitOfWork.Repository<MCita>().Consulta().ToList();
        }
        public int GuardarCita(MCita cita)
        {
            if (cita.CitaId == 0)
            {
                _unitOfWork.Repository<MCita>().Agregar(cita);
                return _unitOfWork.Guardar();
            }
            else
            {
                var citaInDb = _unitOfWork.Repository<MCita>().Consulta().FirstOrDefault(c => c.CitaId == cita.CitaId);
                if (citaInDb != null)
                {
                    citaInDb.MedicoId = cita.MedicoId;
                    citaInDb.PacienteId = cita.PacienteId;
                    cita.FechaCita = citaInDb.FechaCita;
                    citaInDb.Estado = cita.Estado;
                    _unitOfWork.Repository<MCita>().Editar(citaInDb);
                    return _unitOfWork.Guardar();
                }

                return 0;
            }
        }

        public int EliminarCita(int CitaId)
        {
            var citaInDb = _unitOfWork.Repository<MCita>().Consulta().FirstOrDefault(c => c.CitaId == CitaId);
            if (citaInDb != null)
            {
                _unitOfWork.Repository<MCita>().Eliminar(citaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
