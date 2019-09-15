using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class TiresDet
    {
        public string NroCia { get; set; }
        public string CodNeumatico { get; set; }
        public string CodObra { get; set; }
        public DateTime FechaMov { get; set; }
        public string CodCondicion { get; set; }
        public string Ubicacion { get; set; }
        public string CodDiseno { get; set; }
        public string CodEvento { get; set; }
    }
}
