namespace AppliGestionExemple
{
    internal class Program
    {
        public void Execute(string[] args)
        {
            InvoiceComputer invoiceComputer = new InvoiceComputer();

            invoiceComputer.Compute(new ConsoleLogger());
            invoiceComputer.Compute(new ApiLogger());
        }
    }
}
