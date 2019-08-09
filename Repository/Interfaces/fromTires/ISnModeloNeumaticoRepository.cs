using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnModeloNeumaticoRepository  
    {  
        Task<List<SnModeloNeumatico>> GetModeloNeumaticoAll();  
        Task<SnModeloNeumatico> GetModeloNeumaticoById(string codModelo);
    }  
}