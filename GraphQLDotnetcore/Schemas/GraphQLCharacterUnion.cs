using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotnetcore.Schemas
{
    public class GraphQLCharacterUnion : GraphQLUnionType
    {
        public GraphQLCharacterUnion()
            : base("CharacterUnion", "An union of characters in the Star Wars Trilogy")
        {
            this.AddPossibleType(typeof(Droid));
            this.AddPossibleType(typeof(Human));
        }

        public override Type ResolveType(object data)
        {
            if (data is Droid)
                return typeof(Droid);
            else if (data is Human)
                return typeof(Human);

            //If null is returned then the result won't be returned
            return null;
        }
    }
}
