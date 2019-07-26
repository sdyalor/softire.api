using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnProveedores
    {
        public SnProveedores()
        {
            SnNeumaticos = new HashSet<SnNeumaticos>();
        }

        public string CodCia { get; set; }
        public string CodProveedor { get; set; }
        public string Descripcion { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Ruc { get; set; }
        public string Notas { get; set; }
        public string Breve { get; set; }
        public int? Orden { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }

        public virtual SnCiaNeumatico CodCiaNavigation { get; set; }
        public virtual ICollection<SnNeumaticos> SnNeumaticos { get; set; }
    }
}
