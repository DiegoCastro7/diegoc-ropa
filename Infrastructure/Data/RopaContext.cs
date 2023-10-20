using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class RopaContext : DbContext
{
    public RopaContext(DbContextOptions options) : base(options)
    {
    }

    DbSet<Departamento> Departamentos { get; set; }
    DbSet<Pais> Paises { get; set; }
    DbSet<Municipio> Municipios { get; set; }
    DbSet<Prenda> Prendas { get; set; }
    DbSet<DetalleOrden> DetalleOrdenes { get; set; }
    DbSet<Insumo> Insumos { get; set; }
    DbSet<Empresa> Empresas { get; set; }
    DbSet<InsumoPrenda> InsumoPrendas { get; set; }
    DbSet<InsumoProveedor> InsumoProveedores { get; set; }
    DbSet<Proveedor> Proveedores { get; set; }
    DbSet<TipoProteccion> TipoProtecciones { get; set; }
    DbSet<Color> Colores { get; set; }
    DbSet<Genero> Generos { get; set; }
    DbSet<Orden> Ordenes { get; set; }
    DbSet<Inventario> Inventarios { get; set; }
    DbSet<Empleado> Empleados { get; set; }
    DbSet<Estado> Estados { get; set; }
    DbSet<InventarioTalla> InventarioTallas { get; set; }
    DbSet<Cargo> Cargos { get; set; }
    DbSet<TipoEstado> TipoEstados { get; set; }
    DbSet<Talla> Tallas { get; set; }
    DbSet<Venta> Ventas { get; set; }
    DbSet<TipoPersona> TipoPersonas { get; set; }
    DbSet<Cliente> Clientes { get; set; }
    DbSet<DetalleVenta> DetalleVentas { get; set; }
    DbSet<FormaPago> FormaPagos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
