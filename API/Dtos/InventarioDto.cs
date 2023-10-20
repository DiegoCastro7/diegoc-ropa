using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public int Id { get; set; }
        public int CodInv { get; set; }
        public int IdPrendaFk { get; set; }
        public decimal ValorUnitCop { get; set; }
        public decimal ValorUnitUsd { get; set; }
    }
}
