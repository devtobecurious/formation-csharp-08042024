
using DecouverteDelegues;

void AfficherUnMessage(string message)
{
    Console.WriteLine(message);
}

Afficher afficher = AfficherUnMessage;
afficher("il était");

void AfficherUnMessageEnRouge(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

void AfficherUneHistoire(Afficher afficher)
{
    afficher("Il était une fois");
    afficher("Dans une lointaine galaxie");
}

AfficherUneHistoire(AfficherUnMessage);
AfficherUneHistoire(afficher);

AfficherUneHistoire(AfficherUnMessageEnRouge);
AfficherUneHistoire(Console.WriteLine);

// Demain
Afficher dynamiqueDelegue = message =>
{
    Console.WriteLine($"{message.ToUpper()}");
};
AfficherUneHistoire(dynamiqueDelegue);