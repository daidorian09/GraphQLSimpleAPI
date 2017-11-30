using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
using GraphQLDotnetcore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotnetcore.Schemas
{
    public class Mutation : GraphQLObjectType
    {
        private CharacterService service = new CharacterService();

        public Mutation() : base("Mutation", "")
        {
            this.Field("addDroid", (NonNullable<Droid> droid) => CreateAndGet(droid));
              //  .OnChannel("characters")
               // .OnChannel("droid");
        }

        private Droid CreateAndGet(Droid droid)
        {
            return service.CreateDroid(droid);
        }
    }
}
