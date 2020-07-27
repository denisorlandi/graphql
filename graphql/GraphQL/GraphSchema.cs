using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

public class GraphSchema : Schema
{
    public GraphSchema(IDependencyResolver resolver) :
       base(resolver)
    {
        Query = resolver.Resolve<RootQuery>();
    }
}

