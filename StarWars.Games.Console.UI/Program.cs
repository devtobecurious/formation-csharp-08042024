const char charEgal = '=';

// char premierCharactere = titre[0]; // récupération du premier caractère de ma chaine

AfficherTitre("star wars game", DateTime.Now);
AfficherTitreI("a jedi journey");

string saisie = Console.ReadLine();
Console.WriteLine(saisie);

/// fonction dynamique : privée et créée à la volée
void AfficherTitre(string titre, DateTime date)
{
    string pattern = "=== {0} === ! version de livraison : {1:dd/MM/yyyy}";

    // titre = titre.ToUpper().PadLeft(20, charEgal).PadRight(30, charEgal);

    titre = string.Format(pattern, titre.ToUpper(), date);

    Console.WriteLine(titre);
}

void AfficherTitreI(string titre)
{
    titre = $"=== {titre.ToUpper()} === ! version de livraison : {DateTime.Now:ddMMyyyy}";

    Console.WriteLine(titre);
}


