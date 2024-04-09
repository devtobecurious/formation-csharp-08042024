namespace DecouvertePOOEnCSharp
{
    // Dépend du contexte
    /// <summary>
    /// 
    /// </summary>
    public class Lion // CTL Common Type Langage : tous les types possibles ds dotnet
    {
        #region Fields
        private string prenom;
        private int longueur;
        private string emotion = "joie";

        // private DateTime dateNaissance;
        #endregion

        #region Properties
        public DateTime DateNaissance
        {
            get; set;
            //get
            //{
            //    return this.dateNaissance;
            //}
            //set
            //{
            //    this.dateNaissance = value;
            //}
        }

        public int Longueur
        {
            get { return this.longueur; }
            set
            {
                if (this.longueur == int.MinValue)
                {
                    value = 1;
                }
                this.longueur = value;
            }
        }

        public bool IsBig { get { return this.Longueur > 3; } }
        #endregion

        #region Methods
        /// <summary>
        /// Je mange de la nourriture
        /// </summary>
        /// <param name="nourriture">Ne doit pas être null</param>
        public void Manger(string nourriture)
        {
            this.emotion = "extra joie"; // Pattern SRP / Expert : celui qui sait, celui qui fait
            this.Croque();
            Console.WriteLine($"{this.prenom} mange bien ! {this.emotion}");
            this.emotion = "apaisé-e";
        }

        private void Croque()
        {
            Console.WriteLine("Je croque avant de manger");
        }

        public void SetPrenom(string value) // Mutateur / Setter
        {
            if (string.IsNullOrEmpty(value))
            {
                value = "Oops";
            }
            this.prenom = value;
        }

        public string GetPrenom() // Accesseur / Getter 
        {
            return this.prenom.ToLower();
        }

        public string GetEmotion()
        {
            return this.emotion;
        }
        #endregion

        public void Test2()
        {
            throw new System.NotImplementedException();
        }
    }
}
