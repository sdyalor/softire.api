using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnTipoVehiculo
    {
        public SnTipoVehiculo()
        {
            SnVehiculo = new HashSet<SnVehiculo>();
        }

        public string CodCia { get; set; }
        public string CodTipo { get; set; }
        public string Descripcion { get; set; }
        public string Notas { get; set; }
        public string Breve { get; set; }
        public int? Orden { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }

        public virtual SnCiaNeumatico CodCiaNavigation { get; set; }
        public virtual ICollection<SnVehiculo> SnVehiculo { get; set; }
    }
}
