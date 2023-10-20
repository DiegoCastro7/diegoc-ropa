using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class MunicipioRepository : GenericRepository<Municipio>, IMunicipioRepository
    {
        private readonly RopaContext _context;
        public MunicipioRepository(RopaContext context) : base(context)
        {
            _context = context;
        }
    }
}
