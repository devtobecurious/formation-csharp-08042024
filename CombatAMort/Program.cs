using StarWars.Games.Core.Models.Fights;

ICombat combat = new DeathMatchCombat();

Character droide = new Character() { PointsDeVie = 50 };
droide.ArmeParDefaut = new Arbalete("ERR1221");

Character jedi = new Character();
jedi.ArmeParDefaut = new LaserArbalete("ZZEEEE");
jedi.PointsDeVie = 50;

Character test = jedi;
test.PointsDeVie = 60; // je modifie la même instance que jedi

// jedi = new Character();
//jedi = null;
//jedi.Prenom = "test";

try
{
    // Le code ici peut potentiellement planter : donc lancer une exception
    combat.Lancer(jedi, jedi);
}
catch (NullReferenceException ex) when (ex.StackTrace.Contains("TODO"))
{
    // j'attrape l'erreur que si c'est une NullReferenceException et si la stack trace contient TODO
    throw; // ici ça relance la patate chaude et donc ça fait planter ici
}


catch (IOException ex)
{
    // Récupérer mon erreur, sans faire planter mon programme
    Console.WriteLine(ex.Message);
}
//catch (Exception ex)
//{
//    // Récupérer mon erreur, sans faire planter mon programme
//    Console.WriteLine(ex.Message);
//}
finally
{
    Console.WriteLine("Dans les deux cas mon code ici va s'exécuter (ça plante ou pas)");
    // Ici on ferme des bdds par exemple
}


Console.WriteLine("Mon prog ne plante pas");