using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnDisenosNeumaticoRepository : ISnDisenosNeumaticoRepository
    {  
        private readonly NeumaticosContext _context;  
        public SnDisenosNeumaticoRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }

        public Task<List<SnDisenosNeumatico>> GetDisenoNeumaticoById(string codDiseno)
        {
            return _context.SnDisenosNeumatico.Where
            (
                a => (
                    a.CodDiseno == codDiseno

                )
            ).ToListAsync();
        }

        public Task<List<SnDisenosNeumatico>> GetDisenosNeumaticoAll()
        {
            return _context.SnDisenosNeumatico.ToListAsync();
        }
    }  
}