class Program
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Metodo principal");

        var pessoaA = new Pessoa(1, "Alexandre");
        var pessoaB = new Pessoa(1, "Alexandre");

        System.Console.WriteLine("\nCompara PessoaA com PessoaB: {0} \n\n", pessoaA.Equals(pessoaB)); // Podemos usar o metodo Equals() se a classe implementar a interface IEquatable na comparação de objetos

    }
}

public class Pessoa : IEquatable<Pessoa> // Usar IEquatable<Pessoa> quando for necessario comparar valor objetos numa classe
{
    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
    public int Id { get; set; }
    public string Nome { get; set; }

    public bool Equals(Pessoa? pessoa)
    {
        return Nome == pessoa.Nome;
    }
}