using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnModeloNeumaticoRepository : ISnModeloNeumaticoRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnModeloNeumaticoRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }

        public Task<List<SnModeloNeumatico>> GetModeloNeumaticoAll()
        {
            return _context.SnModeloNeumatico.ToListAsync();
        }


        Task<SnModeloNeumatico> ISnModeloNeumaticoRepository.GetModeloNeumaticoById(string codModelo)
        {
            return _context.SnModeloNeumatico.SingleAsync(a => a.CodModelo == codModelo);
        }
        // Task<List<SnModeloNeumatico>> ISnModeloNeumaticoRepository.GetModeloNeumaticoListById(string codModelo)
        // {
        //     return _context.SnModeloNeumatico.Where(a => a.SnNeumaticos == codModelo).ToListAsync();
        // }

    }  
}