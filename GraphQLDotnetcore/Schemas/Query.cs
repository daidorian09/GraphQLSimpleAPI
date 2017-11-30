using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
using GraphQLDotnetcore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotnetcore.Schemas
{
    public class Query : GraphQLObjectType
    {
        public Query() : base("Query", "")
        {
            var service = new CharacterService();

            this.Field("hero", (Episode episode) => service.List(episode));
            this.Field("human", (string id) => service.GetHumanById(id))
                .WithDefaultValue("id", "1000");
            this.Field("droid", (string id) => service.GetDroidById(id));
            this.Field("characterUnion",
                (string id) => (service.GetDroidById(id) as object) ?? (service.GetHumanById(id) as object))
                .ResolveWithUnion<GraphQLCharacterUnion>();
        }
    }
}
