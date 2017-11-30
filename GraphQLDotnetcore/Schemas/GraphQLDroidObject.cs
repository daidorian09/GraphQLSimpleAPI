using GraphQLCore.Type;
using GraphQLDotnetcore.Models;
namespace GraphQLDotnetcore.Schemas
{
  

    public class GraphQLDroidObject : GraphQLObjectType<Droid>
    {
        public GraphQLDroidObject()
                : base("Droid", "A character in the Star Wars Trilogy")
        {
            this.Field("id", e => e.Id).WithDescription("The id of the droid.");
            this.Field("name", e => e.Name).WithDescription("The name of the droid.");
            this.Field("friends", e => e.Friends).WithDescription("The friends of the droid, or an empty list if they have none.");
            this.Field("appearsIn", e => e.AppearsIn).WithDescription("Which movies they appear in.");
            this.Field("primaryFunction", e => e.PrimaryFunction).WithDescription("The primary function of the droid.");
        }
    }

    public class GraphQLApplicationUserInputObject : GraphQLInputObjectType<ApplicationUser>
    {
        public GraphQLApplicationUserInputObject()
                : base("InputApplicationUser", "Input object for application user")
        {
            Field("email", e => e.Email).WithDescription("Application User's email property");
            Field("fullName", e => e.FullName).WithDescription("Application User's FullName property");
            Field("password", e => e.Password).WithDescription("Application User's Password property");
            Field("phoneNumber", e => e.PhoneNumber).WithDescription("Application User's PhoneNumber property");
        }
    }
}