namespace StarWars.Games.Core.Models.Fights
{
    /// <summary>
    /// Contrat qui permet de lancer des combats
    /// </summary>
    public interface ICombat
    {
        /// <summary>
        /// Lancer le combat entre deux attaquants
        /// </summary>
        void Lancer(IAttaquant attaquant, IAttaquant attaquant2);
    }
}
