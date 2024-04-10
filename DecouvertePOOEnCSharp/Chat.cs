namespace DecouvertePOOEnCSharp;

public class Chat : Felin // Héritage d'une seule classe
{
    public override void Dormir()
    {
        Console.WriteLine("Je dors comme un pacha");
    }

    public override void Manger()
    {
        Console.WriteLine("Je ronronnne");
        base.Manger(); // exécute le code de la méthode Manger du parent
    }
}
