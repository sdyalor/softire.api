using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnMedidaNeumaticoRepository  
    {  
        Task<List<SnMedidaNeumatico>> GetMedidaNeumaticoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}