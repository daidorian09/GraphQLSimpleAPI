namespace GraphQLDotnetcore.Schemas
{
    using GraphQLCore.Type;
    using Models;

    public class GraphQLDroidInputObject : GraphQLInputObjectType<Droid>
    {
        public GraphQLDroidInputObject()
                : base("InputDroid", "Input object for a character in the Star Wars Trilogy")
        {
            this.Field("name", e => e.Name)
                .WithDefaultValue("DEFAULT_DROID_NAME");
            this.Field("appearsIn", e => e.AppearsIn);
            this.Field("primaryFunction", e => e.PrimaryFunction);
        }
    }
}