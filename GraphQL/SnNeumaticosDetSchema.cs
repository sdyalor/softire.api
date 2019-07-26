using GraphQL;  
using GraphQL.Types;  
  
namespace softire.api
{  
    public class SnNeumaticosDetSchema : Schema  
    {  
        public SnNeumaticosDetSchema(IDependencyResolver resolver) : base(resolver)  
        {  
            Query = resolver.Resolve<SnNeumaticosDetQuery>();  
        }  
    }  
}  