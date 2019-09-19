using System.Collections.Generic;  
using System.Threading.Tasks;
using softire.api.Models;

namespace softire.api
{  
    public interface ISnNeumaticosViewRepository  
    {  
        Task<List<SnNeumaticosView>> GetNeumaticosViewAll();  
    }  
}