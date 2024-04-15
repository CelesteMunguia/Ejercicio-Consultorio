using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MCita
    {
        [Key]
        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public MMedico MMedico { get; set; }
        public int PacienteId { get; set; }
        public MPaciente MPaciente { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }
        
        
    }
}
