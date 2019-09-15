using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ITiresDetRepository
    {  
        Task<List<TiresDet>> GetTiresDetAll();
    }  
}