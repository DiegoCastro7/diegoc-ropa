using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Empleado : BaseEntity
{
    public int IdEmp { get; set; }
    public string Nombre { get; set; }   
    public int IdCargoFk { get; set; }
    public Cargo Cargos { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int IdMunicipioFk { get; set; } 
    public Municipio Municipios { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<Venta> Ventas { get; set; }
}
