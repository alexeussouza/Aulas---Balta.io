
class Program
{

    static void Main(string[] args)
    {
        System.Console.WriteLine("Metodo principal");

        var pessoa = new Pessoa();

        pessoa = new PessoaFisica(); // uma classe filha tem todas propriedades da classe pai, logo PessoaFisica e do tipo Pessoa
        pessoa = new PessoaJuridica();

        var pessoaFisica = new PessoaFisica();
        pessoa = pessoaFisica; //  UpCAST é o processo de passar o objeto filho para o objeto pai

        pessoaFisica = (PessoaFisica)pessoa; //  DownCAST é o processo de passar o objeto pai para o objeto filho, necessario fazer conversão implicita
        // as Propriedades que PessoaFisica possuia a mais que Pessoa serão perdidas neste cenário.
    }
}

public class Pessoa
{
    public string Nome { get; set; }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
}

public class PessoaJuridica : Pessoa
{
    public string CNPJ { get; set; }
}