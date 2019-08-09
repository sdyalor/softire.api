using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnNeumaticosDetRepository : ISnNeumaticosDetRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnNeumaticosDetRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }  
  
        public Task<List<SnNeumaticosDet>> GetNeumaticosDetAll()  
        {  
            return _context.SnNeumaticosDet.ToListAsync();  
        }  
        public Task<SnNeumaticosDet> GetNeumaticosDetById(string id)
        {
            return _context.SnNeumaticosDet.SingleAsync(x => x.CodNeumatico == id);
        }


        public Task<List<SnNeumaticosDet>> GetNeumaticosDetsById(string codNeumatico,string condicion = "")
        {
            return _context.SnNeumaticosDet.Where
            (a => 
                (
                    condicion != ""?
                    (a.CodNeumatico == codNeumatico && a.CodCondicion == condicion):
                    (a.CodNeumatico == codNeumatico)
                )
            ).OrderBy(a => a.FechaMov).ToListAsync();
        }
    }  
}