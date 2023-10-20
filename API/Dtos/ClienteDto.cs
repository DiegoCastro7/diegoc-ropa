using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; } 
        public string Nombre { get; set; } 
        public int IdTipoPersonaFk { get; set; }
        public DateTime FechaRegistro { get; set; } 
        public int IdMunFk { get; set; }
    }
}
