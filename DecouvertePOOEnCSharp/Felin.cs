namespace DecouvertePOOEnCSharp
{
    public abstract class Felin : Animal
    {
        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("Je me lèche le pelage");
        }

        public void Sauter()
        {
            Console.WriteLine("Je saute");
        }

    }
}
