using System;

namespace Payments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pagamento pag = new Pagamento();
            pag.Vencimento = DateTime.Now;
            pag.Pagar(100);

            //System.Console.WriteLine("Vencimento: {0}", pag.Vencimento);
        }
    }


    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            System.Console.WriteLine("\nPagar: {0}", valor); // regra do pagamento
            System.Console.WriteLine("\nData: {0}", Vencimento); // regra da data, necessario usar using System
        }
    }

    public interface IPagamento // interface é um contrato ou definição, a classe quem implementa segue as regras do contrato
    {

        DateTime Vencimento { get; set; } // não colocar modificador de acesso em propriedades, na implementação define-se o modificador
        void Pagar(double valor); // não precisa das chaves, pois não há implementaçaõ aqui


    }
}