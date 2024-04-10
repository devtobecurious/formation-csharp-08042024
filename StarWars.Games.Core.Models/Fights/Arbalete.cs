namespace StarWars.Games.Core.Models.Fights
{
    public class Arbalete : BaseArme
    {
        public Arbalete(string name) : base(name)
        {
        }

        public override int ValeurCout => 10;
    }

    public class LaserArbalete : BaseArme
    {
        public LaserArbalete(string name) : base(name)
        {
        }

        public override int ValeurCout => 15;
    }
}
