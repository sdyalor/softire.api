using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnModeloVehiculoRepository  
    {  
        Task<List<SnModeloVehiculo>> GetModeloVehiculoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}