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

        // public Task<List<SnVehiculo>> GetVehiculoAll()
        // {
        //     return _context.SnVehiculo.ToListAsync();
        // }
        // public Task<SnNeumaticosDet> GetNeumaticosDet(string id)  
        // {  
        //     return _context.SnNeumaticosDet.FirstOrDefault(x => x. == id));  
        // }  
        // public Task<SnNeumaticosDet> GetNeumaticosDetById(string id)
        // {
        //     return _context.SnNeumaticosDet.SingleAsync(x => x.CodNeumatico == id);
        // }
    }  
}