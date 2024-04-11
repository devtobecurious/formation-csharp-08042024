namespace DecouverteEvenements
{
    internal delegate void FinirCode(Code code);

    internal class Developper
    {
        public event FinirCode? CodeFini;

        public Code Create()
        {
            Code code = new Code()
            {
                Content = "public class Test {}"
            };

            // Prévenir toutes les personnes qui sont abonnées à mon travail
            this.CodeFini?.Invoke(code);
            //this.CodeFini?.Invoke(code);

            return code;
        }
    }
}
