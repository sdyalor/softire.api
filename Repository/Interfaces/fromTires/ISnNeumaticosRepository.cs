using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnNeumaticosRepository  
    {  
        Task<List<SnNeumaticos>> GetNeumaticosAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}