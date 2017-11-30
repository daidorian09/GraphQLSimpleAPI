using Microsoft.AspNetCore.Mvc;
using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQLDotnetcore.Controllers
{
    [Route("grapgql")]
    public class GraphQLController : Controller
    {
        private IGraphQLSchema schema;

        public GraphQLController(IGraphQLSchema schema)
        {
            this.schema = schema;
        }

        [HttpPost("create")]
        public IActionResult Post([FromBody] GraphiQLInput input)
        {
            if (input is null)
                return BadRequest(error: "xxx");


            return this.Json(this.schema.Execute(input.Query));
        }

        [HttpPost("test")]
        public IActionResult Post([FromBody] JObject model)
        {
            var graphQLInput = JsonConvert.DeserializeObject<GraphiQLInput>(model.ToString());
            if (graphQLInput is null)
                return BadRequest(error: "xxx");


            return this.Json(this.schema.Execute(graphQLInput.Query));
        }

        private static dynamic GetVariables(GraphiQLInput input)
        {
            var variables = input.Variables?.ToString();

            if (string.IsNullOrEmpty(variables))
                return new ExpandoObject();

            return JsonConvert.DeserializeObject<ExpandoObject>(variables);
        }
    }
}