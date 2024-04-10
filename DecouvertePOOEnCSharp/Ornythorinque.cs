
namespace DecouvertePOOEnCSharp;

public class Ornythorinque : Animal
{
    public override void Manger()
    {
        base.Manger();
        Console.WriteLine("Je mange dans un terrier");
    }
}
