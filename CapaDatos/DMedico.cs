using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMedico
    {
        UnitOfWork _unitOfWork;

        public DMedico()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
       

        public List<MMedico> medicoTodos()
        {
            return _unitOfWork.Repository<MMedico>().Consulta().ToList();
        }

        public int GuardarUnidades(MMedico medico)
        {

            if (medico.MedicoId == 0)
            {
                _unitOfWork.Repository<MMedico>().Agregar(medico);
                return _unitOfWork.Guardar();
            }
            else
            {
                var MedicoInDb = _unitOfWork.Repository<MMedico>().Consulta().FirstOrDefault(c => c.MedicoId == medico.MedicoId);

                if (MedicoInDb != null)
                {
                    MedicoInDb.Nombres = medico.Nombres;
                    MedicoInDb.Apellidos = medico.Apellidos;
                    MedicoInDb.Estado = medico.Estado;
                    MedicoInDb.FechaIngreso = medico.FechaIngreso;
                    _unitOfWork.Repository<MMedico>().Editar(MedicoInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarMedico(int medicoId)
        {
            var MedicoInDb = _unitOfWork.Repository<MMedico>().Consulta().FirstOrDefault(c => c.MedicoId == medicoId);
            if (MedicoInDb != null)
            {
                _unitOfWork.Repository<MMedico>().Eliminar(MedicoInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }

       
    }
}
