using GraphQL.Types;  
  
namespace softire.api
{  
    public class SnNeumaticosDetQuery : ObjectGraphType  
    {  
        public SnNeumaticosDetQuery(
            ISnVehiculoRepository snVehiculoRepository,
            ISnMarcaVehiculoRepository snMarcaVehiculoRepository,
            ISnModeloVehiculoRepository snModeloVehiculoRepository,
            ISnTipoVehiculoRepository snTipoVehiculoRepository,
            ISnConfiguracionRepository snConfiguracionRepository,
            ISnNeumaticosRepository snNeumaticosRepository,
            ISnCondicionesNeumaticoRepository snCondicionesNeumaticoRepository,
            ISnDisenosNeumaticoRepository snDisenosNeumaticoRepository,
            ISnMarcaNeumaticoRepository snMarcaNeumaticoRepository,
            ISnMedidaNeumaticoRepository snMedidaNeumaticoRepository,
            ISnModeloNeumaticoRepository snModeloNeumaticoRepository,
            ISnProveedoresRepository snProveedoresRepository,
            ISnNeumaticosDetRepository snNeumaticosDetRepository
            )  
        //snNeumaticosDetR.. ??
        {  
            Field<ListGraphType<SnNeumaticosDetType>>(
                "neumatico",
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id"}
                ),
                resolve: context => 
                         {
                             var id = context.GetArgument<string>("id");
                             return  snNeumaticosDetRepository.GetNeumaticosDetAll();
                         }
            );
            Field<SnNeumaticosDetType>(
                "snneumatico",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>>
                    {
                        Name = "id"
                    }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<string>("id");
                    return snNeumaticosDetRepository.GetNeumaticosDetById(id);
                }
            );
            /* fromVehicles */
            Field<ListGraphType<SnVehiculoType>>(
                "vehiculoVehiculo",
                resolve: context => snVehiculoRepository.GetVehiculoAll()
            );
            Field<ListGraphType<SnMarcaVehiculoType>>(
                "marcaVehiculo",
                resolve: context => snMarcaVehiculoRepository.GetMarcaVehiculoAll()
            );
            Field<ListGraphType<SnModeloVehiculoType>>(
                "modeloVehiculo",
                resolve: context => snModeloVehiculoRepository.GetModeloVehiculoAll()
            );
            Field<ListGraphType<SnTipoVehiculoType>>(
                "tipoVehiculo",
                resolve: context => snTipoVehiculoRepository.GetTipoVehiculoAll()
            );
            Field<ListGraphType<SnConfiguracionType>>(
                "configuracion",
                resolve: context => snConfiguracionRepository.GetConfiguracionAll()
            );
            //* This is for Tires */
            Field<ListGraphType<SnNeumaticosType>>(
                "neumaticos",
                resolve: context => snNeumaticosRepository.GetNeumaticosAll()
            );
            Field<ListGraphType<SnCondicionesNeumaticoType>>(
                "condicionesNeumatico",
                resolve: context => snCondicionesNeumaticoRepository.GetCondicionesNeumaticoAll()
            );
            Field<ListGraphType<SnDisenosNeumaticoType>>(
                "disenosNeumatico",
                resolve: context => snDisenosNeumaticoRepository.GetDisenosNeumaticoAll()
            );
            Field<ListGraphType<SnMarcaNeumaticoType>>(
                "marcaNeumatico",
                resolve: context => snMarcaNeumaticoRepository.GetMarcaNeumaticoAll()
            );
            Field<ListGraphType<SnMedidaNeumaticoType>>(
                "medidaNeumatico",
                resolve: context => snMedidaNeumaticoRepository.GetMedidaNeumaticoAll()
            );
            Field<ListGraphType<SnModeloNeumaticoType>>(
                "modeloNeumatico",
                resolve: context => snModeloNeumaticoRepository.GetModeloNeumaticoAll()
            );
            /** NoDependent */
            Field<ListGraphType<SnProveedoresType>>(
                "proveedores",
                resolve: context => snProveedoresRepository.GetProveedoresAll()
            );
            Field<ListGraphType<SnNeumaticosDetType>>(  
                "snneumaticosdet",
                resolve: context => snNeumaticosDetRepository.GetNeumaticosDetAll() 
                );
        }  
    }  
}  