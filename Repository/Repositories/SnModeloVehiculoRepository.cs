using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnModeloVehiculoRepository : ISnModeloVehiculoRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnModeloVehiculoRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }

        public Task<List<SnModeloVehiculo>> GetModeloVehiculoAll()
        {
            return _context.SnModeloVehiculo.ToListAsync();
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