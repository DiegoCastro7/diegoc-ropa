using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Inventario : BaseEntity
{
    public int CodInv { get; set; }
    public int IdPrendaFk { get; set; }
    public Prenda Prendas { get; set; }
    public decimal ValorUnitCop { get; set; }
    public decimal ValorUnitUsd { get; set; }
    public ICollection<InventarioTalla> InventarioTallas { get; set; }
    public ICollection<DetalleVenta> DetalleVentas { get; set; }
}
