using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnProveedoresRepository : ISnProveedoresRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnProveedoresRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }  
  
        public Task<List<SnProveedores>> GetProveedoresAll()
        {
            return _context.SnProveedores.ToListAsync();  
        }
    }  
}