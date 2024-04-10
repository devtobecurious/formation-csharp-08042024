namespace DecouvertePOOEnCSharp
{

    public interface IVolant
    {
        void Voler();
    }

    public interface IAviation : IVolant
    {
        void Decoller();
    }
}
