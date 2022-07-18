using System;

class Programa
{

    static void PagamentoBoleto(double valor)
    {
        Console.WriteLine("\nPagamento Boleto: => {0}", valor);

    }

    static void PagamentoApplePay(double valor)
    {
        Console.WriteLine("\nPagamento ApplePay: => {0}", valor);

    }

    static void Main(string[] args)
    {

        var pagar = new Pagamento.Pagar(PagamentoBoleto); // passo para funcao delegate a classe que vai executar o metodo Pagar()
        // classe deve ter o mesmo tipo de retorno e o mesmo tipo de passagem de parametro 
        pagar(125);

        pagar = new Pagamento.Pagar(PagamentoApplePay); // passo para funcao delegate a classe que vai executar o metodo Pagar()
        // classe deve ter o mesmo tipo de retorno e o mesmo tipo de passagem de parametro 
        pagar(250);
    }

}

public class Pagamento
{

    public delegate void Pagar(double valor); // usando delegate este metodo não será executado aqui, vai ser executado em outra classe
}

