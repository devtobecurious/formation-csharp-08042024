namespace DecouvertePOOEnCSharp
{
    /// <summary>
    /// Koala c'est un bel animal
    /// </summary>
    public class Koala
    {
        #region Constructors
        public Koala() : this("Koko")
        {
            Console.WriteLine("{0} je suis construit", this.Prenom);
        }

        public Koala(string prenom) : this(prenom, 10)
        {
            Console.WriteLine("{0} je me construis", this.Prenom);
        }

        public Koala(string prenom, float poids)
        {
            this.Prenom = prenom;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Prénom du koala
        /// </summary>
        public string Prenom
        {
            get;
            private set;
        }
        #endregion
    }
}