using System;
using GraphQLCore.Type;
namespace GraphQLDotnetcore.Schemas
{


    public class StarWarsSchema : GraphQLSchema
    {
        public StarWarsSchema()
        {
            var rootQuery = new Query();
            var rootMutation = new Mutation();
            var subscriptionType = new Subscription();

            AddKnownType(new GraphQLCharacterUnion());
            AddKnownType(new GraphQLCharacterInterface());
            AddKnownType(new GraphQLHumanObject());
            AddKnownType(new GraphQLDroidObject());
            AddKnownType(new GraphQLEpisodeEnum());
            AddKnownType(new GraphQLDroidInputObject());
            AddKnownType(rootQuery);
            AddKnownType(rootMutation);
            AddKnownType(subscriptionType);

            Query(rootQuery);
            Mutation(rootMutation);
            Subscription(subscriptionType);
        }
    }
}