using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnNeumaticosDetType : ObjectGraphType<SnNeumaticosDet>  
    {  
        public SnNeumaticosDetType()  
        {  
        Field(a => a.NroCia);
        Field(a => a.CodNeumatico);
        Field(a => a.CodObra);
        Field(a => a.FechaMov);  
        Field(a => a.CodCondicion);
        Field(a => a.Ubicacion); 
        Field(a => a.CodDiseno); 
        Field(a => a.CodEvento);
        Field(a => a.RemanenteProm,nullable: true);
        Field(a => a.Kilometraje,nullable:true); 
        Field(a => a.CostoPromedio,nullable:true);
        Field(a => a.Notas);
        Field(a => a.CodProveedor);
        Field(a => a.Posicion,nullable:true); 
        Field(a => a.Costo,nullable:true); 
        Field(a => a.Horometro,nullable:true);
        Field(a => a.Presion,nullable:true); 
        Field(a => a.Fecha,nullable:true); 
        Field(a => a.Usuario); 
        Field(a => a.Rem1,nullable:true); 
        Field(a => a.Rem2,nullable:true); 
        Field(a => a.Rem3,nullable:true); 
        Field(a => a.CodFalla);
        Field(a => a.Idcarga); 
        Field(a => a.Linecarga,nullable:true); 
        }  
    }  
} 