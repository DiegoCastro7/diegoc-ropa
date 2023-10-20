using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class InventarioTalla
{
    public int IdInvFk { get; set; }
    public Inventario Inventarios { get; set; }
    public int IdTallaFk { get; set; }
    public Talla Tallas { get; set; }
}
