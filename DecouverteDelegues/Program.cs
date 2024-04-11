
using DecouverteDelegues;



Afficher afficher = AfficherUnMessage;


afficher("il était");

void AfficherUnMessageEnRouge(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

void RaconterUneHistoire(Afficher afficher)
{
    afficher("Il était une fois");
    afficher("Dans une lointaine galaxie");
}

RaconterUneHistoire(AfficherUnMessage);
RaconterUneHistoire(afficher);

RaconterUneHistoire(AfficherUnMessageEnRouge);
RaconterUneHistoire(Console.WriteLine);





void AfficherUnMessage(string message)
{
    Console.WriteLine($"{message.ToUpper()}");
}
RaconterUneHistoire(AfficherUnMessage);

//Afficher dynamiqueDelegue = message => // fonction anonyme ou expression lambda
//{
//    Console.WriteLine($"{message.ToUpper()}");
//};

Afficher dynamiqueDelegue = message => Console.WriteLine($"{message.ToUpper()}");
RaconterUneHistoire(dynamiqueDelegue);


RaconterUneHistoire(message => Console.WriteLine($"{message.ToUpper()}"));


void RaconterUneHistoireCompliquee(AfficherAvecUnParam afficher)
{
    afficher("Il était une fois", 1);
    afficher("un ours qui buvait ...", 2);
}

RaconterUneHistoireCompliquee((message, param) => Console.WriteLine(message, param));

// à travailler après la formation
// Action<string> afficherBis = Console.WriteLine;