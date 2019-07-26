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
        public float? RemanenteProm { get; set; }
        public float? Kilometraje { get; set; }
        public float? CostoPromedio { get; set; }
        public string Notas { get; set; }
        public string CodProveedor { get; set; }
        public float? Posicion { get; set; }
        public float? Costo { get; set; }
        public float? Horometro { get; set; }
        public float? Presion { get; set; }
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
