using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotnetcore.Schemas
{
    public class GraphQLCharacterInterface : GraphQLInterfaceType<ICharacter>
    {
        public GraphQLCharacterInterface()
            : base("Character", "A character in the Star Wars Trilogy")
        {
            this.Field("id", e => e.Id).WithDescription(
                "The id of the character.");

            this.Field("name", e => e.Name).WithDescription(
                "The name of the character.");

            this.Field("friends", e => e.Friends).WithDescription(
                "The friends of the character, or an empty list if they " +
                "have none.");

            this.Field("appearsIn", e => e.AppearsIn).WithDescription(
                "Which movies they appear in.");
        }
    }
}
