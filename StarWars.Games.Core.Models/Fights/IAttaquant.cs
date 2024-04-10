namespace StarWars.Games.Core.Models.Fights
{
    public interface IAttaquant : IAvecPointsDeVie
    {
        void Attaquer(IAvecPointsDeVie autre);

        IArme ArmeParDefaut { get; set; }
    }
}
