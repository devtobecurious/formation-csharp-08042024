namespace CalculTvaAvecDelegues
{
    public class CalculerTTC
    {
        public decimal Calculer(decimal prixHT, GetTva? getTva = null)
        {
            //if (getTva != null) // type guard
            //{
            //    string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            //    return prixHT * (1 + getTva(culture));
            //}

            string culture = System.Globalization.CultureInfo.CurrentCulture.Name;

            decimal? valeurTva = getTva?.Invoke(culture);

            return prixHT * (1 + (valeurTva ?? 0.2M));
        }

        //public void Calculer(decimal prixHT, GetTva? getTva = null)
        //{
        //    string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
        //    //return prixHT * (1 + getTva(culture));
        //}

        public decimal Calculer(decimal prixHT, int codePays)
        {
            return 18 * prixHT;
        }
    }
}
