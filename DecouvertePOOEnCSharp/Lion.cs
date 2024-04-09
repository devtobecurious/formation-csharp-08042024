namespace DecouvertePOOEnCSharp
{
    // Dépend du contexte
    public class Lion // CTL Common Type Langage : tous les types possibles ds dotnet
    {
        #region Attributs
        public string Prenom;
        public int Longueur;
        private string emotion = "joie";
        #endregion

        #region Methods
        public void Manger()
        {
            this.emotion = "extra joie"; // Pattern SRP / Expert : celui qui sait, celui qui fait
            Console.WriteLine($"{this.Prenom} mange bien ! {this.emotion}");
            this.emotion = "apaisé-e";
        }
        #endregion
    }
}
