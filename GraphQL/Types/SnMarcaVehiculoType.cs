using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnMarcaVehiculoType : ObjectGraphType<SnMarcaVehiculo>  
    {  
        public SnMarcaVehiculoType()  
        { 
        Field(a => a.CodCia);
        Field(a => a.CodMarca);
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