using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnModeloVehiculoType : ObjectGraphType<SnModeloVehiculo>  
    {  
        public SnModeloVehiculoType()  
        { 
        Field(a => a.CodCia);
        Field(a => a.CodMarca);
        Field(a => a.CodModelo);
        Field(a => a.Descripcion);
        Field(a => a.Notas);
        Field(a => a.Breve);
        Field(a => a.Orden);
        Field(a => a.Estado);
        Field(a => a.Fecha);
        Field(a => a.Usuario);
        Field(a => a.Idcarga, nullable:true);
        }  
    }  
} 