using System;
using System.Collections.Generic;

namespace softire.api.Models
{
    public partial class SnVehiculo
    {
        public string CodCia { get; set; }
        public string CodObra { get; set; }
        public string CodVehiculo { get; set; }
        public string Placa { get; set; }
        public string Prefijo { get; set; }
        public string CodMarca { get; set; }
        public string CodModelo { get; set; }
        public string CodTipo { get; set; }
        public string CodConfiguracion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Variable { get; set; }
        public string IndVehiAlma { get; set; }
        public string NroSerie { get; set; }
        public string Notas { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Clase { get; set; }
        public string Situacion { get; set; }
        public string Linea { get; set; }
        public string Propiedad { get; set; }
        public string Idcarga { get; set; }
        public int? Linecarga { get; set; }

        public virtual SnMarcaVehiculo Cod { get; set; }
        public virtual SnTipoVehiculo Cod1 { get; set; }
        public virtual SnModeloVehiculo Cod2 { get; set; }
        public virtual SnConfiguracion CodC { get; set; }
        public virtual SnCiaNeumatico CodCiaNavigation { get; set; }
        public virtual SnObraNeumatico CodNavigation { get; set; }
    }
}
