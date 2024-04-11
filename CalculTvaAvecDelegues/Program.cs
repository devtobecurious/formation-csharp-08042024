using CalculTvaAvecDelegues;

var calculeur = new CalculerTTC();

//decimal GetTvaBrut(string codePays)
//{
//    // Appel de la base de données, ça prend du temps ...
//    return 0.2M;
//}

//decimal GetTvaDepuisUnFichierTexte(string codePays)
//{
//    // Appel du fichier, ça prend du temps ...

//    return 0.21M;
//}

//GetTva[] tvaMethods = [GetTvaBrut, GetTvaDepuisUnFichierTexte];

//var result = calculeur.Calculer(20, tvaMethods[0]);


//result = calculeur.Calculer(100, param =>
//{
//    return 0.25M;
//});

//result = calculeur.Calculer(100, param => 0.25M);

var result = calculeur.Calculer(10);
//calculeur.Calculer();
