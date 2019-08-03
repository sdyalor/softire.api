using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnDisenosNeumaticoType : ObjectGraphType<SnDisenosNeumatico>  
    {  
        public SnDisenosNeumaticoType()  
        {
        Field(a => a.CodCia);
        Field(a => a.CodDiseno);
        Field(a => a.Descripcion);
        Field(a => a.Notas);
        Field(a => a.Breve);
        Field(a => a.Orden);
        Field(a => a.Estado);
        Field(a => a.Fecha);
        Field(a => a.Usuario);

        }  
    }  
} 