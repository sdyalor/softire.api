using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnNeumaticosDet
    {
        public string NroCia { get; set; }
        public string CodNeumatico { get; set; }
        public string CodObra { get; set; }
        public DateTime FechaMov { get; set; }
        public string CodCondicion { get; set; }
        public string Ubicacion { get; set; }
        public string CodDiseno { get; set; }
        public string CodEvento { get; set; }
        public decimal? RemanenteProm { get; set; }
        public decimal? Kilometraje { get; set; }
        public decimal? CostoPromedio { get; set; }
        public string Notas { get; set; }
        public string CodProveedor { get; set; }
        public decimal? Posicion { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Horometro { get; set; }
        public decimal? Presion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public int? Rem1 { get; set; }
        public int? Rem2 { get; set; }
        public int? Rem3 { get; set; }
        public string CodFalla { get; set; }
        public string Idcarga { get; set; }
        public int? Linecarga { get; set; }
    }
}
