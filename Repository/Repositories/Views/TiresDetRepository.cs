using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class TiresDetRepository : ITiresDetRepository
    {  
        private readonly NeumaticosContext _context;  
        public TiresDetRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }  
  
        public Task<List<TiresDet>> GetTiresDetAll()
        {
            var tiresDet = new List<TiresDet>();
            // using(var context_ = new NeumaticosContext())
            // {
                var tiresSelection = from tire in _context.SnNeumaticosDet
                join design in _context.SnDisenosNeumatico
                on tire.CodDiseno equals design.CodDiseno
                select new TiresDet{
                                    NroCia = tire.NroCia,
                                    CodNeumatico = tire.CodNeumatico,
                                    CodObra = tire.CodObra,
                                    FechaMov = tire.FechaMov,
                                    CodCondicion = tire.CodCondicion,
                                    Ubicacion = tire.Ubicacion,
                                    CodDiseno = design.Descripcion,
                                    CodEvento = tire.CodEvento
                                    
                };
                // foreach(var tire in tiresSelection)
                // {
                //     tiresDet.Add(tire);
                // }
                                
            // }
            // return tiresDet;
            return tiresSelection.ToListAsync();
        }  
    }
}