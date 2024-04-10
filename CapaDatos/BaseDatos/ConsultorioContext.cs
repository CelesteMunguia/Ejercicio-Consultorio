using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos
{
    public class ConsultorioContext: DbContext
    {
        public ConsultorioContext() : base("Consultorio")
        {
            
        }
    }
}
