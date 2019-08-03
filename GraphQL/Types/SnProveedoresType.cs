using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnProveedoresType : ObjectGraphType<SnProveedores>  
    {  
        public SnProveedoresType()  
        {  
        Field(a => a.CodCia);
        Field(a => a.CodProveedor);
        Field(a => a.Descripcion);
        Field(a => a.Contacto);
        Field(a => a.Direccion);
        Field(a => a.Ciudad);
        Field(a => a.Telefono);
        Field(a => a.Departamento);
        Field(a => a.Fax);
        Field(a => a.Celular);
        Field(a => a.Ruc);
        Field(a => a.Notas);
        Field(a => a.Breve);
        Field(a => a.Orden, nullable:true);
        Field(a => a.Estado);
        Field(a => a.Fecha);
        Field(a => a.Usuario);
        }  
    }  
} 