using Microsoft.EntityFrameworkCore;
using softire.api.Models;
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
  
namespace softire.api
{  
    public class SnNeumaticosViewRepository : ISnNeumaticosViewRepository
    {  
        private readonly NeumaticosContext _context;
        public SnNeumaticosViewRepository(NeumaticosContext context)  
        {  
            _context = context;  
        }

        public Task<List<SnNeumaticosView>> GetNeumaticosViewAll()
        {
                var tiresSelection = from tire in _context.SnNeumaticos
                                       join proveedor in _context.SnProveedores
                                        on tire.CodProveedor equals proveedor.CodProveedor
                                       join marca in _context.SnMarcaNeumatico
                                        on tire.CodMarca equals marca.CodMarca 
                                       join medida in _context.SnMedidaNeumatico
                                        on tire.CodMedida equals medida.CodMedida
                                       join modelo in _context.SnModeloNeumatico
                                        on tire.CodModelo equals modelo.CodModelo
                                    //    join diseno in _context.SnDisenosNeumatico
                                    //     on tire.CodDiseno equals diseno.CodDiseno
                                    //    join estado in _context.SnCondicionesNeumatico
                                    //     on tire.Estado equals estado.CodCondicion
                                       select new SnNeumaticosView{
                                            CodCia = tire.CodCia,
                                            CodObra = tire.CodObra,
                                            CodNeumatico = tire.CodNeumatico,
                                            DotSerie = tire.DotSerie,
                                            CodProveedor = tire.CodProveedor,
                                            CodProveedorDescripcion =  proveedor.Descripcion,
                                            FechaCompra = tire.FechaCompra,
                                            NroDocu = tire.NroDocu,
                                            NroRequ = tire.NroRequ,
                                            CodMarca = tire.CodMarca,
                                            CodMarcaDescripcion = marca.Descripcion,
                                            CodMedida = tire.CodMedida,
                                            CodMedidaDescripcion = medida.Descripcion,
                                            CodModelo = tire.CodModelo,
                                            CodModeloDescripcion = modelo.Descripcion,
                                            CodDiseno = tire.CodDiseno,
                                            // CodDisenoDescripcion = diseno.Descripcion,
                                            RemanenteIni = tire.RemanenteIni,
                                            RemanenteProm = tire.RemanenteProm,
                                            RemanenteMinima = tire.RemanenteMinima,
                                            PrecioCompra = tire.PrecioCompra,
                                            FecIngAlma = tire.FecIngAlma,
                                            Notas = tire.Notas,
                                            CodMotivoBaja = tire.CodMotivoBaja,
                                            TapaValvula = tire.TapaValvula,
                                            ExtencionValvula = tire.ExtencionValvula,
                                            Estado = tire.Estado,
                                            // EstadoDescripcion = estado.Descripcion,
                                            Fecha = tire.Fecha,
                                            Usuario = tire.Usuario,
                                            NroPlieges = tire.NroPlieges,
                                            Rem1 = tire.Rem1,
                                            Rem2 = tire.Rem2,
                                            Rem3 = tire.Rem3,
                                            CodCausa = tire.CodCausa,
                                            ZonaAveria = tire.ZonaAveria,
                                            CheckPoint = tire.CheckPoint,
                                            Idcarga = tire.Idcarga,
                                            Linecarga = tire.Linecarga,
                                            RemanenteInicial = tire.RemanenteInicial
                                        };
            return tiresSelection.ToListAsync();
        }  
    }
}