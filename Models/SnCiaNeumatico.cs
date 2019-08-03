using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnCiaNeumatico
    {
        public SnCiaNeumatico()
        {
            SnCondicionesNeumatico = new HashSet<SnCondicionesNeumatico>();
            SnConfiguracion = new HashSet<SnConfiguracion>();
            SnDisenosNeumatico = new HashSet<SnDisenosNeumatico>();
            SnMarcaNeumatico = new HashSet<SnMarcaNeumatico>();
            SnMedidaNeumatico = new HashSet<SnMedidaNeumatico>();
            SnModeloNeumatico = new HashSet<SnModeloNeumatico>();
            SnModeloVehiculo = new HashSet<SnModeloVehiculo>();
            SnNeumaticos = new HashSet<SnNeumaticos>();
            SnObraNeumatico = new HashSet<SnObraNeumatico>();
            SnParametrosNeuma = new HashSet<SnParametrosNeuma>();
            SnProveedores = new HashSet<SnProveedores>();
            SnTipoVehiculo = new HashSet<SnTipoVehiculo>();
            SnVehiculo = new HashSet<SnVehiculo>();
        }

        public string CodCia { get; set; }
        public string Descripcion { get; set; }
        public string Notas { get; set; }
        public string Breve { get; set; }
        public int Orden { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }

        public virtual ICollection<SnCondicionesNeumatico> SnCondicionesNeumatico { get; set; }
        public virtual ICollection<SnConfiguracion> SnConfiguracion { get; set; }
        public virtual ICollection<SnDisenosNeumatico> SnDisenosNeumatico { get; set; }
        public virtual ICollection<SnMarcaNeumatico> SnMarcaNeumatico { get; set; }
        public virtual ICollection<SnMedidaNeumatico> SnMedidaNeumatico { get; set; }
        public virtual ICollection<SnModeloNeumatico> SnModeloNeumatico { get; set; }
        public virtual ICollection<SnModeloVehiculo> SnModeloVehiculo { get; set; }
        public virtual ICollection<SnNeumaticos> SnNeumaticos { get; set; }
        public virtual ICollection<SnObraNeumatico> SnObraNeumatico { get; set; }
        public virtual ICollection<SnParametrosNeuma> SnParametrosNeuma { get; set; }
        public virtual ICollection<SnProveedores> SnProveedores { get; set; }
        public virtual ICollection<SnTipoVehiculo> SnTipoVehiculo { get; set; }
        public virtual ICollection<SnVehiculo> SnVehiculo { get; set; }
    }
}
