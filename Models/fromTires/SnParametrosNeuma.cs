using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnParametrosNeuma
    {
        public string CodCia { get; set; }
        public string CodObra { get; set; }
        public string CodParametro { get; set; }
        public int ParaIni { get; set; }
        public int ParaFin { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public string Notas { get; set; }
        public string Breve { get; set; }
        public int Orden { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Imagen { get; set; }

        public virtual SnObraNeumatico Cod { get; set; }
        public virtual SnCiaNeumatico CodCiaNavigation { get; set; }
    }
}
