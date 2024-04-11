using DecouverteEvenements;

Director director = new Director();
Boss boss = new();
Developper developper = new Developper();

developper.CodeFini += boss.ControlerCode;
developper.CodeFini += director.ControlerVitesse;
developper.CodeFini += director.ControlerVitesse;

developper.CodeFini += code =>
{
    Console.WriteLine("Super code !");
};

Code code = developper.Create();
Console.WriteLine("Code fait {0}", code.Content);


// A la fin du programme
developper.CodeFini -= boss.ControlerCode;
developper.CodeFini -= director.ControlerVitesse;