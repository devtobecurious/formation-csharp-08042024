namespace StarWars.Games.Core.Models
{
    /// <summary>
    /// Le roman sur le profil et comment l'utiliser
    /// </summary>
    public class Profil
    {
        #region Constructors
        public Profil(string prenom, DateOnly dateNaissance)
        {
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets prenom
        /// </summary>
        public string Prenom { get; private set; } = "";

        public DateOnly DateNaissance { get; init; }
        #endregion
    }
}

namespace Test
{
    public class Profil
    {
    }
}
