namespace DecouvertePOOEnCSharp
{
    public class Animal
    {
        #region Public methods
        public void Manger()
        {
            Console.WriteLine("{0} Je mange", this.Prenom);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Prénom du koala
        /// </summary>
        public string Prenom
        {
            get;
            set;
        }
        #endregion
    }
}
