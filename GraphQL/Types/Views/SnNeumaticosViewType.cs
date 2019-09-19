using System;
using GraphQL.Types;
using softire.api.Models;

namespace softire.api
{  
    public class SnNeumaticosViewType : ObjectGraphType<SnNeumaticosView>  
    {  
        public SnNeumaticosViewType(ISnModeloNeumaticoRepository snModeloNeumaticoRepository)  
        {
        Field(a =>a.CodCia);
        Field(a =>a.CodObra);
        Field(a =>a.CodNeumatico);
        Field(a =>a.DotSerie,nullable:true);
        Field(a =>a.CodProveedor);
        Field(a =>a.CodProveedorDescripcion);
        Field(a =>a.FechaCompra,nullable:true);
        Field(a =>a.NroDocu,nullable:true);
        Field(a =>a.NroRequ);
        Field(a =>a.CodMarca);
        Field(a =>a.CodMarcaDescripcion);
        Field(a =>a.CodMedida);
        Field(a =>a.CodMedidaDescripcion);
        Field(a =>a.CodModelo,nullable:true);
        Field(a =>a.CodModeloDescripcion,nullable:true);
        Field(a =>a.CodDiseno);
        Field(a =>a.CodDisenoDescripcion);
        Field(a =>a.RemanenteIni);
        Field(a =>a.RemanenteProm,nullable:true);
        Field(a =>a.RemanenteMinima,nullable:true);
        Field(a =>a.PrecioCompra,nullable:true);
        Field(a =>a.FecIngAlma,nullable:true);
        Field(a =>a.Notas);
        Field(a =>a.CodMotivoBaja);
        Field(a =>a.TapaValvula);
        Field(a =>a.ExtencionValvula);
        Field(a =>a.Estado);
        Field(a =>a.EstadoDescripcion);
        Field(a =>a.Fecha,nullable:true);
        Field(a =>a.Usuario);
        Field(a =>a.NroPlieges,nullable:true);
        Field(a =>a.Rem1,nullable:true);
        Field(a =>a.Rem2,nullable:true);
        Field(a =>a.Rem3,nullable:true);
        Field(a =>a.CodCausa);
        Field(a =>a.ZonaAveria);
        Field(a =>a.CheckPoint);
        Field(a =>a.Idcarga);
        Field(a =>a.Linecarga,nullable:true);
        Field(a =>a.RemanenteInicial,nullable:true);
        }
    }  
} 