using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnProveedoresRepository  
    {  
        Task<List<SnProveedores>> GetProveedoresAll();  
        // Task<SnNeumaticosDet> GetNeumaticosDetById(string id);
    }  
}