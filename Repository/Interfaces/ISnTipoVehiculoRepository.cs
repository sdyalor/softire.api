using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnTipoVehiculoRepository  
    {  
        Task<List<SnTipoVehiculo>> GetTipoVehiculoAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}