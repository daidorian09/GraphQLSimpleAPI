using System;
using System.Collections.Generic;
namespace GraphQLDotnetcore.Models
{
    public enum Episode
    {
        NEWHOPE = 4,
        EMPIRE = 5,
        JEDI = 6
    }

    public class GraphiQLInput
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public dynamic Variables { get; set; }
    }

    public class ApplicationUser
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class Human : ICharacter
    {
        public IEnumerable<Episode> AppearsIn { get; set; }
        public IEnumerable<ICharacter> Friends { get; set; }
        public string HomePlanet { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string SecretBackstory { get { throw new Exception("secretBackstory is secret."); } }
    }

    public class Droid : ICharacter
    {
        public IEnumerable<Episode> AppearsIn { get; set; }
        public IEnumerable<ICharacter> Friends { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrimaryFunction { get; set; }
    }

    public interface ICharacter
    {
        IEnumerable<Episode> AppearsIn { get; set; }
        IEnumerable<ICharacter> Friends { get; set; }
        string Id { get; set; }
        string Name { get; set; }
    }
}
