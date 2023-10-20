using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargoRepository Cargos {get;}
        IEmpleadoRepository Empleados {get;}
        IEstadoRepository Estados {get;}
        IFormaPagoRepository FormasPago {get;}
        IColorRepository Colores {get;}
        IProveedorRepository Proveedores {get;}
        IClienteRepository Clientes {get;}
        IOrdenRepository Ordenes {get;}
        IDetalleOrdenRepository DetalleOrdenes {get;}
        IDetalleVentaRepository DetalleVentas {get;}
        IEmpresaRepository Empresas {get;}
        IGeneroRepository Generos {get;}
        IInsumoRepository Insumos {get;}
        IMunicipioRepository Municipios {get;}
        IPaisRepository Paises {get;}
        IPrendaRepository Prendas {get;}
        ITallaRepository Tallas {get;}
        ITipoEstadoRepository TipoEstados {get;}
        ITipoPersonaRepository TipoPersonas {get;}
        ITipoProteccionRepository TipoProtecciones {get;}
        IVentaRepository Ventas {get;}
        IInventarioRepository Inventarios {get;}
        IDepartamentoRepository Departamentos {get;}


        Task<int> SaveAsync();
    }
}