using System;
using System.Collections.Generic;
using System.Linq;

namespace M01A25
{
    class Program
    {

        static void Main(string[] args)
        {
            // utilizar este tipo de lista quando for fazer apenas leitura, nela existem poucos tipos de metodos para maniputação
            //IEnumerable tem apenas os metodos Equals, GetEnumerator,GetHashCode, GetType e ToString
            IEnumerable<Pagamento> pag1 = new List<Pagamento>();

            // List possui diversos metodos para manipulação da lista
            List<Pagamento> pag3 = new List<Pagamento>();

            // ICollection possui diversos metodos para manipulação da lista
            ICollection<Pagamento> pag4 = new List<Pagamento>();

            // IList possui diversos metodos para manipulação da lista
            var pagamento = new List<Pagamento>();

            pagamento.Add(new Pagamento(1));
            pagamento.Add(new Pagamento(2, "Alexandre"));
            pagamento.Add(new Pagamento(3, "andre"));
            pagamento.Add(new Pagamento(4, "Carlos"));
            pagamento.Add(new Pagamento(5, "Marcia"));

            foreach (var pag in pagamento)
            {

                System.Console.Write(pag.Id.ToString());
                System.Console.WriteLine(" - " + pag.Nome + "\n" );
            }

            System.Console.WriteLine("\nExemploe Where");
            var pag6 = pagamento.Where(x=> x.Nome == "andre"); // faz um fitro e tras todas ocorrencias na lista em um IEnumerable 
            foreach(var p in pag6){
                System.Console.Write( p.Id + " - ") ;
                System.Console.Write(p.Nome + "\n");
            }

            System.Console.WriteLine("\nExemploe Fisrt");
            var pag7 = pagamento.First(y=> y.Nome == "Carlos"); // executa filtro na lista com Firt 
            System.Console.WriteLine(pag7.Nome);

            System.Console.WriteLine("\nExemploe Where");
            foreach(var p in pagamento.Where(x=>x.Nome == "Alexandre")){ // permite fazer um filtro detro do foreach
                System.Console.Write( p.Id + " - ") ;
                System.Console.Write(p.Nome + "\n");
            }

            System.Console.WriteLine("\nExemploe Any");
            var existe = pagamento.Any(x=> x.Id == 6); // verifica se existe o item informado na lista
            System.Console.WriteLine("Existe pagamento na posição informada? " + existe);

            System.Console.WriteLine("\nExemploe Count");
            var resultado = pagamento.Count(x=> x.Id == 6); // verifica a quantidade de itens na lista
            System.Console.WriteLine("Itens na lista: " + resultado);

            System.Console.WriteLine("\nExemploe Skip");
            foreach (var pag in pagamento.Skip(2)) // pula 2 itens na lista
            {

                System.Console.Write(pag.Id.ToString());
                System.Console.WriteLine(" - " + pag.Nome + "\n" );
            }

            System.Console.WriteLine("\nExemploe Take");
            foreach (var pag in pagamento.Take(4)) // exibe 4 itens na lista
            {

                System.Console.Write(pag.Id.ToString());
                System.Console.WriteLine(" - " + pag.Nome + "\n" );
            }

            pagamento.ToArray(); // converte a lista para ToArray
            pagamento.ToList(); // converte a lista para Tolist
            pagamento.AsEnumerable(); // converte a lista para IEnumerable
        }
    }

    public class Pagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pagamento(int id)
        {
            Id = id;
        }
        public Pagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}