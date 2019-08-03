using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnDisenosNeumaticoRepository  
    {  
        Task<List<SnDisenosNeumatico>> GetDisenosNeumaticoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}