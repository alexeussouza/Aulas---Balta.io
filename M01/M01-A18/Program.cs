class Program
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Classe Principal");

    }
}

public interface IPagamento
{

    DateTime Vencimento { get; set; }
}

public abstract class Pagamento : IPagamento // classe abstrata não pode ser instanciada, apenas herdada por outras classes
{
    //classe abstrata pode ter uma implementaçao base, as interfaces não tem implementação base.
    public DateTime Vencimento { get; set; }
    public virtual void Pagar(double valor)
    {

    }
}

public class PagamentoBoleto : Pagamento
{

    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }

}

public class PagamentoCartaoCredito : Pagamento
{

    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }

}

public class PagamentoApplePay : Pagamento
{

    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }

}
