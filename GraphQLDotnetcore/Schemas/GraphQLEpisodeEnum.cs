namespace GraphQLDotnetcore.Schemas
{
    using GraphQLCore.Type;
    using Models;

    public class GraphQLEpisodeEnum : GraphQLEnumType<Episode>
    {
        public GraphQLEpisodeEnum() :
            base("Episode", "One of the films in the Star Wars Trilogy")
        {
        }
    }
}