using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnMarcaNeumaticoRepository  
    {  
        Task<List<SnMarcaNeumatico>> GetMarcaNeumaticoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}