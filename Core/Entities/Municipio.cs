using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Municipio : BaseEntity
{
    public string Nombre { get; set; } 
    public int IdDepFk { get; set; }
    public Departamento Departamentos { get; set; }
    public ICollection<Empresa> Empresas { get; set; }
    public ICollection<Cliente> Clientes { get; set; }
    public ICollection<Empleado> Empleados { get; set; }
    public ICollection<Proveedor> Proveedores { get; set; }
    
}
