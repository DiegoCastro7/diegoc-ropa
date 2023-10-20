using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class OrdenDto
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleadoFk { get; set; }
        public int IdClienteFk { get; set; }
        public int IdEstadoFk { get; set; }
    }
}
