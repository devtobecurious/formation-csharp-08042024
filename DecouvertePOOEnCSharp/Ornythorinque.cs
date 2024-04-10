
namespace DecouvertePOOEnCSharp;

public class Ornythorinque : Animal, ILoonyToons
{
    public override void Manger()
    {
        base.Manger();
        Console.WriteLine("Je mange dans un terrier");
    }

    public override void Dormir()
    {
        Console.WriteLine("Je dors dans mon terrier");
    }

    public void FaireCoinCoin()
    {
        Console.WriteLine("Je fais coin coin");
    }
}
