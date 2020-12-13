using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace DataManager.App_Start
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        // Modify all parameters 
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            // Instantiate a List of Parameters if the parameters is not already instantiated 
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter
            {
                name = "Authorization", 
                @in = "header", 
                description = "access token", 
                required = false, 
                type = "string"
            });

        }
    }
}