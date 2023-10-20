using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public int IdEmp { get; set; }
        public string Nombre { get; set; }   
        public int IdCargoFk { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdMunicipioFk { get; set; }
    }
}
