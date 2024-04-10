namespace DecouvertePOOEnCSharp;

public class Chat : Felin, ILoonyToons // Héritage d'une seule classe
{
    public override void Dormir()
    {
        Console.WriteLine("Je dors comme un pacha");
    }

    public void FaireCoinCoin()
    {
        Console.WriteLine("Je suis Sylvestre");
    }

    public override void Manger()
    {
        Console.WriteLine("Je ronronnne");
        base.Manger(); // exécute le code de la méthode Manger du parent
    }
}
