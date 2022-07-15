using System;

namespace M01_A05
{
  class Program
  {

    static void Main(string[] args)
    {
        Pagamento pag = new Pagamento();
        pag.Dispose(); // destruindo o metodo construtor da classe

        using(var pagamento = new Pagamento()){ // usando using ele chama o metodo Disposable() no final da classe, necessario que a classe extenda IDisposable() 
          System.Console.WriteLine( "Processando o pagamento");
        }


        pag.Pagar("123456");
        PagamentoCartao pac = new PagamentoCartao();
        pac.Pagar("22222");
        
    }
  }

  public class Pagamento : IDisposable // implementa a interface IDisposable para poder destruir o construtor no final da execução com Dispose()
  {
    //Garbage Collector (coletor de lixo) 

    public Pagamento()
    {
      System.Console.WriteLine("\n\nIniciando o pagamento\n"); // sempre que for feito new Pagamento será impresso este texto deste construtor
     }

    public virtual void Pagar(string numero){
      System.Console.WriteLine( "Pagar cartão ==> classe Pai");
    }
    
    //Struct: Tipo de valor, memoria stack

    //Classe: Tipo de referência, armazena o endereço dos dados. Memoria heap
    
    //Objeto: possui propriedades, metodos e eventos, tem acesso por referência

    // Encapsulamento: é o principio de separar o programa em partes, o mais isolado possivel. Serve para controlar o acesso as propriedades, metodos e eventos de uma classe.

    // Abstração: esconder os detalhes do objeto das outras classes, usando private

    // Herança: permite criar novas classes apartir de classes ja existentes, aproveitando suas variaveis e metodos.

    // Polimorfismo: é o princípio de ter n formas invocar metodos que tem a mesma assinatura, mas com comportamentos distintos.

    //Private: acesso apenas dentro da classe de origem

    //Protected: permite acesso aos metodos e propriedades a classes derivadas, pode usar base para acessar a classe pai

    //Internal: Disponível dentro do mesmo Assembler ou namespace

    //Classe sem modificador funciona como private
    
    // prop => atalho para criar propriedade com get e set

    // prop g => public int MyProperty { get; private set; } permite leitura da propriedade mas não permite setar valor para a variavel.

    // ctor => atalho para criar metodo construtor numa classe

    // cw => atalho para criar Console.WriteLine("  ")

    // s vm => atalho para criar static void Main(string[] args)

    // Sobrecarga: diferentes versões do mesmo metodo em uma classe, assinaturas diferentes
    public void Pag (string numero){ } // Sobrecarga:
    public void Pag(string numero, int valor){  } // Sobrecarga
    public void Pag(string numero, int valor, int valor2){  } // Sobrecarga

        public void Dispose()
        {
            System.Console.WriteLine("Finalizando o pagamento.");
        }
  }

  class PagamentoCartao : Pagamento{
    
    //Sobrescrita: usando virtual no metodo podemos usar override para criar um metodo com mesmo nome
    public override void Pagar(string numero) // sobrescrita
    {
      base.Pagar("1234"); // chamando metodo pagar da classe pai
      System.Console.WriteLine( "Pagar com cartão ==> classe Filho"); // chamando metodo pagar da classe filho        
      Movimento.Mover();
      Movimento.Distancia= 25;
      System.Console.WriteLine(Movimento.Distancia);

    }
  }

  public static class Movimento{ // não é possivel instanciar classes estaticas, logo se for criado um construtor ocorre erro na classe
      
      public static int Distancia { get; set; }
      public static void Mover(){
        System.Console.WriteLine( "\n\nMovendo....");
      }
  }
}