using GraphQL.Types;  
  
namespace softire.api
{  
    public class SnNeumaticosDetQuery : ObjectGraphType  
    {  
        public SnNeumaticosDetQuery(ISnNeumaticosDetRepository snNeumaticosDetRepository,ISnVehiculoRepository snVehiculoRepository)  
        //snNeumaticosDetR.. ??
        {  
            Field<ListGraphType<SnNeumaticosDetType>>(  
                "snneumaticosdet",
                resolve: context => snNeumaticosDetRepository.GetNeumaticosDetAll() 
                );
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
            Field<ListGraphType<SnVehiculoType>>(
                "vehiculo",
                resolve: context => snVehiculoRepository.GetVehiculoAll()
            );
        }  
    }  
}  