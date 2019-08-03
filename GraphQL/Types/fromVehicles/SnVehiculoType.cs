using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnVehiculoType : ObjectGraphType<SnVehiculo>  
    {  
        public SnVehiculoType()  
        { 
        Field(a => a.CodCia);
        Field(a => a.CodObra);
        Field(a => a.CodVehiculo);
        Field(a => a.Placa);
        Field(a => a.Prefijo);
        Field(a => a.CodMarca);
        Field(a => a.CodModelo);
        Field(a => a.CodTipo);
        Field(a => a.CodConfiguracion);
        Field(a => a.Descripcion);
        Field(a => a.Estado);
        Field(a => a.Variable);
        Field(a => a.IndVehiAlma);
        Field(a => a.NroSerie);
        Field(a => a.Notas);
        Field(a => a.Fecha);
        Field(a => a.Usuario);
        Field(a => a.Clase);
        Field(a => a.Situacion);
        Field(a => a.Linea);
        Field(a => a.Propiedad);
        Field(a => a.Idcarga);
        Field(a => a.Linecarga,nullable: true);
        }  
    }  
} 