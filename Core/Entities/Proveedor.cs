using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Proveedor : BaseEntity
{
    public int NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersonas { get; set; }
    public int IdMunicipioFk { get; set; }
    public Municipio Municipios { get; set; }
    public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
}
