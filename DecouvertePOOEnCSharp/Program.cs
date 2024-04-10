//var lionPrenom = "Simba";
//var lionLongueur = 2.0M;

//void LionMange(string prenom, decimal longueur)
//{

//}


using DecouvertePOOEnCSharp;

Lion lion = new Lion();
lion.Longueur = 2;
var longueur = lion.Longueur;

bool estGros = lion.IsBig;


// lion.prenom = "Simba";
lion.SetPrenom("Simba");
var prenom = lion.GetPrenom();
var emotion = lion.GetEmotion();

lion.Manger("");


Lion lion2 = new Lion();
lion2.Longueur = 3;
//lion2.prenom = "Mufasa";
lion.SetPrenom("Mufasa");

lion2.Manger("");


Koala koala = new Koala("Koko");
koala = new Koala("Koka");

Koala koki = new Koala();
// koala.Prenom = "koko";


Chat chat = new Chat();
chat.Prenom = "Bougie";
//chat.Sauter();
//chat.Manger();

//Felin felin = new Chat();
Animal animal = new Chat();
animal.Prenom = "Onyx";
//Animal animal2 = new Lion();
//string saisie = Console.ReadLine();
//animal.Prenom = Console.ReadLine();

animal.Manger();



List<Animal> list = new();
list.Add(new Ornythorinque());
list.Add(new Goeland());
list.Add(new Chat());
list.Add(new ChauveSouris());

Animal[] tablAnimals = [new Ornythorinque()];


for (int i = 0; i < list.Count; i++)
{
    list[i].Manger();
}

foreach (var item in list)
{
    item.Manger();
    item.Dormir();
}

list.ForEach(item => item.Manger()); // vous saurez faire ce soir

// (animal as Chat).Sauter();
