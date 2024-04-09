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