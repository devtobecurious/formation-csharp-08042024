GrilleAfficheur afficheurGrille = new();


Console.WriteLine("Tu veux quelle couleur ?");
string couleurSaisie = Console.ReadLine();

Enum.TryParse(couleurSaisie, true, out CouleurAffichage couleurAffichage);

AfficherQuelquePart afficherQuelquePart = null;
switch (couleurAffichage)
{
    case CouleurAffichage.Vert:
        {
            afficherQuelquePart = content =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(content);
                Console.ForegroundColor = ConsoleColor.White;
            };
        }
        break;

    case CouleurAffichage.Sombre:
        {
            afficherQuelquePart = content =>
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(content);
                Console.ForegroundColor = ConsoleColor.White;
            };
        }
        break;

    case CouleurAffichage.Rouge:
        {
            afficherQuelquePart = content =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(content);
                Console.ForegroundColor = ConsoleColor.White;
            };
        }
        break;
}

afficheurGrille.Afficher(10, 10, afficherQuelquePart);