namespace StarWars.Games.Core.Models.Fights
{
    public abstract class BaseArme : IArme
    {
        private string name;

        public BaseArme(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public abstract int ValeurCout { get; }
    }
}
