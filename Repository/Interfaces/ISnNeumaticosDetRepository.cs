using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnNeumaticosDetRepository  
    {  
        Task<List<SnNeumaticosDet>> GetNeumaticosDetAll();  
        Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}