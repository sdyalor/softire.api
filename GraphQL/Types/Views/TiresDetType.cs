using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class TiresDetType : ObjectGraphType<TiresDet>  
    {  
        public TiresDetType()  
        {  
            Field(a => a.NroCia);
            Field(a => a.CodNeumatico);
            Field(a => a.CodObra);
            Field(a => a.FechaMov);  
            Field(a => a.CodCondicion);
            Field(a => a.Ubicacion); 
            Field(a => a.CodDiseno); 
            Field(a => a.CodEvento);
        }  
    }  
} 