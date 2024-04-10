namespace DecouvertePOOEnCSharp
{
    public class ChauveSouris : Animal, IVolant
    {
        public override void Dormir()
        {
            Console.WriteLine("Je dors la tête à l'envers");
        }



        public void Voler()
        {
            Console.WriteLine(" I believe I can fly");
        }
    }
}
