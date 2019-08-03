using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnConfiguracionRepository  
    {  
        Task<List<SnConfiguracion>> GetConfiguracionAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}