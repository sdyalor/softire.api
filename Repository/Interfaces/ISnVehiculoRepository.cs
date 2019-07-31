using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnVehiculoRepository  
    {  
        Task<List<SnVehiculo>> GetVehiculoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}