namespace DecouvertePOOEnCSharp.Zoo
{
    public abstract class Animal
    {
        #region Public methods
        public virtual void Manger()
        {
            Console.WriteLine("{0} Je mange", this.Prenom);
        }
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
