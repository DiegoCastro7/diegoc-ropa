using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class InsumoProveedor
{
    public int IdInsumoFk { get; set; }
    public Insumo Insumos { get; set; }
    public int IdProveedorFk { get; set; }
    public Proveedor Proveedores { get; set; }
}
