namespace GraphQLDotnetcore.Schemas
{
    using GraphQLCore.Events;
    using GraphQLCore.Execution;
    using GraphQLCore.Type.Complex;
    using Models;
    using Services;
    using System.Linq;

    public class Subscription : GraphQLSubscriptionType
    {
        public Subscription() : base("Subscription", "", new InMemoryEventBus())
        {
            var service = new CharacterService();
            this.Field("characters", (Episode episode) => service.List(episode))
                .WithSubscriptionFilter((IContext<ICharacter> ctx, Episode episode) =>
                    ctx.Instance.AppearsIn != null && ctx.Instance.AppearsIn.Contains(episode) == true)
                .OnChannel("characters");

            this.Field("newDroid", ((IContext<Droid> ctx) => service.GetDroidById(ctx.Instance.Id)))
                .OnChannel("droid");
        }
    }
}