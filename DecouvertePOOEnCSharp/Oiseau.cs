namespace DecouvertePOOEnCSharp
{
    public abstract class Oiseau : Animal, IVolant
    {
        public void Voler()
        {
            Console.WriteLine("Je vole, Je vole");
        }
    }
}
