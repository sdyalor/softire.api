using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnTipoVehiculoType : ObjectGraphType<SnTipoVehiculo>  
    {  
        public SnTipoVehiculoType()  
        { 
        Field(a => a.CodCia);
        Field(a => a.CodTipo);
        Field(a => a.Descripcion);
        Field(a => a.Notas);
        Field(a => a.Breve);
        Field(a => a.Orden, nullable: true);
        Field(a => a.Estado);
        Field(a => a.Fecha);
        Field(a => a.Usuario);
        }  
    }  
} 