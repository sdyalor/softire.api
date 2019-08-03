using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnMarcaVehiculoRepository : ISnMarcaVehiculoRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnMarcaVehiculoRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }

        public Task<List<SnMarcaVehiculo>> GetMarcaVehiculoAll()
        {
            return _context.SnMarcaVehiculo.ToListAsync();
        }
    }  
}