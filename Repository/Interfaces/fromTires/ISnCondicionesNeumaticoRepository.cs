using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnCondicionesNeumaticoRepository  
    {  
        Task<List<SnCondicionesNeumatico>> GetCondicionesNeumaticoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}