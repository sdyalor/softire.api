using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnDisenosNeumatico
    {
        public SnDisenosNeumatico()
        {
            SnNeumaticos = new HashSet<SnNeumaticos>();
        }

        public string CodCia { get; set; }
        public string CodDiseno { get; set; }
        public string Descripcion { get; set; }
        public string Notas { get; set; }
        public string Breve { get; set; }
        public int Orden { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }

        public virtual SnCiaNeumatico CodCiaNavigation { get; set; }
        public virtual ICollection<SnNeumaticos> SnNeumaticos { get; set; }
    }
}
