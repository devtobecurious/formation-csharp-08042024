using CalculTvaAvecDelegues;

var calculeur = new CalculerTTC();

decimal GetTvaBrut(string codePays)
{
    // Appel de la base de données, ça prend du temps ...
    return 0.2M;
}

decimal GetTvaDepuisUnFichierTexte(string codePays)
{
    // Appel du fichier, ça prend du temps ...
    return 0.2M;
}

GetTva[] tvaMethods = [GetTvaBrut, GetTvaDepuisUnFichierTexte];

var result = calculeur.Calculer(20, tvaMethods[0]);
