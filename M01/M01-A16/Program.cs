namespace Pagar
{
    public class Program
    {

        public static void Main()
        {

            Console.WriteLine("Hello, World!");
            Pagamento pag = new Pagamento();

            pag.PropriedadeA = 25;

            pag.PropriedadeB = 20;

            System.Console.WriteLine("\nPropriedade A:  {0}", pag.PropriedadeA);
            System.Console.WriteLine("\nPropriedade B:  {0}", pag.PropriedadeB);

        }
    }
}

