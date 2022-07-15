using System;

class Programa
{

    static void RealizarPagamento(double valor)
    {
        Console.WriteLine("Valor pago {0}", valor);

    }

    static void Main(string[] args)
    {

        var pagar = new Pagamento.Pagar(RealizarPagamento); // passo para funcao delegate a classe que vai executar o metodo Pagar()
        // classe deve ter o mesmo tipo de retorno e o mesmo tipo de passagem de parametro 
        pagar(125);
    }

}

public class Pagamento
{

    public delegate void Pagar(double valor); // usando delegate este metodo não será executado aqui, vai ser executado em outra classe
}

