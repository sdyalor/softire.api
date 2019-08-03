using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnMarcaVehiculoRepository  
    {  
        Task<List<SnMarcaVehiculo>> GetMarcaVehiculoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}