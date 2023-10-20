using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Prenda : BaseEntity
{
    public int IdPrenda { get; set; }
    public string Nombre { get; set; }
    public decimal ValorUnitCop { get; set; }
    public decimal ValorUnitUsd { get; set; }
    public int IdEstadoFk { get; set; }
    public Estado Estados { get; set; }
    public int IdTipoProteccionFk { get; set; }
    public TipoProteccion TipoProtecciones { get; set; }
    public int IdGeneroFk { get; set; }
    public Genero Generos { get; set; }
    public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
}
