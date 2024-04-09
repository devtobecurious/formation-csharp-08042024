using System.Globalization;

const char charEgal = '=';

System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


// char premierCharactere = titre[0]; // récupération du premier caractère de ma chaine
#region Exécution code
AfficherTitre("star wars game", DateTime.Now);
AfficherTitreI("a jedi journey");

SaisirProfil();
ChoisirPersonnage();

string saisie = Console.ReadLine();
Console.WriteLine(saisie);
#endregion

#region Librairies
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
    int numeroVersion = 1 / 3;
    titre = $"=== {titre.ToUpper()} === ! version de livraison : {DateTime.Now:ddMMyyyy}-{numeroVersion.ToString("00.00")}";

    Console.WriteLine(titre);
}

void SaisirProfil()
{
    Console.WriteLine("SAISIE PROFIL");
    SaisirDateNaissance();
}

void SaisirDateNaissance()
{
    bool saisieOK = false;

    while (!saisieOK)
    {
        Console.WriteLine("Saisi ta date de naissance");
        string dateString = Console.ReadLine();

        if (!string.IsNullOrEmpty(dateString))
        {
            // DateTime dateNaissance = DateTime.Parse(dateString); // brut : trop risqué !!
            //DateTime dateNaissance = DateTime.Now;
            //dateNaissance = new DateTime(2024, 1, 12);

            saisieOK = (DateTime.TryParse(dateString, out DateTime dateNaissance)); //out : pour passage de référence de ma variable à TryParse

            #region Travail sur la culture
            // Culture par date
            // var culture = new CultureInfo("en-US");
            // var culture = new CultureInfo("en-US"); // dotnet 4.x
            CultureInfo cultureA = new CultureInfo("en-US"); // dotnet 1.0
            CultureInfo culture = new("en-US"); // dotnet 7

            culture = new("fr-FR");


            // var nbCultures; on ne peut pas si on n'affecte pas
            var nbCultures = 1.0D;
            // nbCultures = "coucou"; il a déjà le type Double, donc pas possible en string
            Console.WriteLine("Ta date de naissance est " + dateNaissance.ToString("dddd dd MMMM yyyy", culture));

            // Culture par executable

            #endregion

            bool ageValide = ValiderAge(dateNaissance, 13);
            if (!ageValide)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Petit malin, tu n'as pas le droit d'y jouer");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}

bool ValiderAge(DateTime date, int ageRequis)
{
    TimeSpan resultat = DateTime.Now - date; // une comparaison de date donne un TimeSpan
    int age = (int)resultat.TotalDays / 365;

    return age >= ageRequis;
}

void ChoisirPersonnage()
{
    //string[] persos = new string[4];
    //persos[0] = "Luke";
    //persos[1] = "Leia";
    //persos[2] = "Anakin";
    //persos[3] = "Qui Gon";

    string[] persos = ["Luke", "Leia", "Anakin", "Qui Gon"];


    Console.WriteLine("Choisis ton perso");
    for (int i = 0; i < persos.Length; i++)
    {
        Console.WriteLine("{0}: {1}", i, persos[i]);
        Console.WriteLine($"{i} : {persos[i]}");
    }
    string persoIndexString = Console.ReadLine();
    Console.WriteLine("Tu as choisi le perso {0}", persos[int.Parse(persoIndexString)]);
}
#endregion