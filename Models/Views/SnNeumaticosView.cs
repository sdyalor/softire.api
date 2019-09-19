using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnNeumaticosView
    {
        public string CodCia { get; set; }
        public string CodObra { get; set; }
        public string CodNeumatico { get; set; }
        public string DotSerie { get; set; }
        public string CodProveedor { get; set; }
        public string CodProveedorDescripcion {get;set;}
        public DateTime? FechaCompra { get; set; }
        public string NroDocu { get; set; }
        public string NroRequ { get; set; }
        public string CodMarca { get; set; }
        public string CodMarcaDescripcion { get; set; }
        public string CodMedida { get; set; }
        public string CodMedidaDescripcion { get; set; }
        public string CodModelo { get; set; }
        public string CodModeloDescripcion { get; set; }
        public string CodDiseno { get; set; }
        public string CodDisenoDescripcion { get; set; }
        public string RemanenteIni { get; set; }
        public decimal? RemanenteProm { get; set; }
        public decimal? RemanenteMinima { get; set; }
        public decimal? PrecioCompra { get; set; }
        public DateTime? FecIngAlma { get; set; }
        public string Notas { get; set; }
        public string CodMotivoBaja { get; set; }
        public string TapaValvula { get; set; }
        public string ExtencionValvula { get; set; }
        public string Estado { get; set; }
        public string EstadoDescripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public int? NroPlieges { get; set; }
        public int? Rem1 { get; set; }
        public int? Rem2 { get; set; }
        public int? Rem3 { get; set; }
        public string CodCausa { get; set; }
        public string ZonaAveria { get; set; }
        public string CheckPoint { get; set; }
        public string Idcarga { get; set; }
        public int? Linecarga { get; set; }
        public decimal? RemanenteInicial { get; set; }
    }
}
