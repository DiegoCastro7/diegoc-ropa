using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TipoProteccionRepository : GenericRepository<TipoProteccion>, ITipoProteccionRepository
    {
        private readonly RopaContext _context;
        public TipoProteccionRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}
