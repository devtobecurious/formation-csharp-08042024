namespace DecouvertePOOEnCSharp.Zoo
{
    public abstract class Animal
    {
        #region Public methods
        public virtual void Manger()
        {
            Console.WriteLine("{0} Je mange", this.Prenom);
        }
        //public abstract void Manger();


        public abstract void Dormir();

        //public void SeDeplacer() // Impossible à redéfinir
        //{
        //    Console.WriteLine("Je me déplace");
        //}

        //public virtual void SeDeplacer() // Tu peux mais pas obligé, redéfinir
        //{
        //    Console.WriteLine("Je me déplace");
        //}

        //public abstract void SeDeplacer(); // Tu es obligé-e
        #endregion

        #region Properties
        /// <summary>
        /// Prénom du koala
        /// </summary>
        private string prenom;
        public string Prenom
        {
            get { return this.prenom; }
            set
            {
                if (value.Length > 3)
                {
                    this.prenom = value;
                }
            }
            #endregion
        }
    }
}
