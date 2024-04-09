//var lionPrenom = "Simba";
//var lionLongueur = 2.0M;

//void LionMange(string prenom, decimal longueur)
//{

//}


using DecouvertePOOEnCSharp;

Lion lion = new Lion();
lion.Longueur = 2;
lion.Prenom = "Simba";

lion.Manger();


Lion lion2 = new Lion();
lion2.Longueur = 3;
lion2.Prenom = "Mufasa";

lion2.Manger();