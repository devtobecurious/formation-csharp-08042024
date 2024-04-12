//List<int> ints = [1, 2, 3, 4, 5, 6, 8, 9, 10];
using DecouverteLinq;
using Microsoft.EntityFrameworkCore;

List<int> ints2 = new() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

ints.Add(11);

int result = ints.Sum();
int lePlusGrand = ints.Max();
int premier = ints.First();
int dernier = ints.Last();
var list = ints.Select(value => $"{value}. {value} ??");

foreach (var i in list)
{
    Console.WriteLine(i);
}
// int lePlusGrandBis = ints.Max(value => value);

#region Travail avec des listes d'objets

List<Wookiee> wookiees = new List<Wookiee>()
{
    new() { Age = 100, NbPoils = 100, Prenom = "Chewie", Planete = new() { Label = "Kashyyk" } },
    new() { Age = 10, NbPoils = 0, Prenom = "Chewa" },
    new() { Age = 200, NbPoils = 1000000, Prenom = "Arthik" },
};

var query = from wookiee in wookiees
            let premierCaractere = wookiee.Prenom.Substring(0, 1)
            where wookiee.Planete != null && !string.IsNullOrEmpty(wookiee.Planete.Label)
            orderby premierCaractere
            //orderby wookiee.Prenom descending
            select wookiee;

var queryTotalAge = from wookiee in wookiees
                    select wookiee.Age;

int sommeAge = queryTotalAge.Sum();

int sommeBis = wookiees.Sum(item => item.Age);


var listWookieesCreee = query.ToList(); // operator d'exécution
var premierWookiee = query.FirstOrDefault(); // je ré exécute ma requête

foreach (var wookiee in listWookieesCreee)
{
    Console.WriteLine($"wookiee : {wookiee.Prenom} vit dans la planète {wookiee.Planete.Label}");
}

foreach (var wookiee in listWookieesCreee)
{
    Console.WriteLine($"wookiee : {wookiee.Prenom} vit dans la planète {wookiee.Planete.Label}");
}
#endregion


#region Vers l'infini euh non la base

DbContextOptionsBuilder<DefaultDbContext> builder = new DbContextOptionsBuilder<DefaultDbContext>();

// C'est ici que nous allons spécifier notre provider ! (sql server, mysql, ...)
builder.UseSqlServer("Server=DESKTOP-1446PBQ\\MSSQLSERVER2022;Database=StarWars.Database.DEV;Trusted_Connection=True;TrustServerCertificate=True;"); // A mettre dans un fichier de settings externe et non compilé !!

var dbContext = new DefaultDbContext(builder.Options); // TODO: il manque des params ..

var queryDB = from wookiee in dbContext.Wookiees
                  //where wookiee.Planete != null && !string.IsNullOrEmpty(wookiee.Planete.Label)
                  //where wookiee.Prenom.Contains("Che")
              orderby wookiee.Prenom descending
              select wookiee;

var listVenantDb = queryDB.Where(item => item.NbPoils > 10).ToList(); // Ici je fais la requete SQL

foreach (var venant in listVenantDb)
{
    Console.WriteLine($"{venant.Prenom}");
}


var nouveauWookiee = new Wookiee()
{
    Age = 800,
    NbPoils = 12,
    Prenom = "Kilokt"
};
dbContext.Wookiees.Add(nouveauWookiee);
//Task task = dbContext.SaveChangesAsync(); // Eager
//Task.WaitAll(task);

await dbContext.SaveChangesAsync();
// Tout le code ici est asynchrone

#endregion