namespace AppliGestionExemple
{
    public class ApiLogger : ILogger
    {
        public void Log(string message)
        {
            HttpClient client = new HttpClient();
            // j'envoie ma requete à un serveur de mon log
        }
    }
}
