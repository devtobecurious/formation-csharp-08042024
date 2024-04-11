namespace CalculTvaAvecDelegues
{
    public class CalculerTTC
    {
        public decimal Calculer(decimal prixHT, GetTva getTva)
        {
            string culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            return prixHT * (1 + getTva(culture));
        }
    }
}
