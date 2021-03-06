namespace M01A23
{

    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            var pessoaContexto = new ContextoDados<Pessoa>(); // passando para ContextoDados<Pessoa> uma entidade do tipo Pessoa
            pessoaContexto.Salvar(pessoa); // Passando para o metodo salvar um objeto do tipo pessoa

            var aluno = new Aluno();
            var alunoContexto = new ContextoDados<Aluno>(); // passando para ContextoDados<Aluno> uma entidade do tipo Aluno
            alunoContexto.Salvar(aluno); // Passando para o metodo salvar um objeto do tipo aluno

            var professor = new Professor();
            var professorContexto = new ContextoDados<Professor>(); // passando para ContextoDados<Aluno> uma entidade do tipo Professor
            professorContexto.Salvar(professor); // Passando para o metodo salvar um objeto do tipo professor


            var EntidadeContexto = new ContextoDados<Pessoa, Aluno, Professor>(); // passando para ContextoDados<> 3 tipos de entidade, 

            EntidadeContexto.Salvar(pessoa); // Passando para o metodo salvar um objeto do tipo pessoa
            EntidadeContexto.Salvar(aluno); // Passando para o metodo salvar um objeto do tipo aluno
            EntidadeContexto.Salvar(professor); // Passando para o metodo salvar um objeto do tipo professor

            var EntidadeContextoGenerico = new ContextoDadosGenerico<Pessoa, Aluno, Professor, IDiretor>(); // passando para ContextoDados<> 3 tipos de entidade, 

            var diretor = new Diretor();

            EntidadeContextoGenerico.Salvar(pessoa); // Passando para o metodo salvar um objeto do tipo pessoa
            EntidadeContextoGenerico.Salvar(aluno); // Passando para o metodo salvar um objeto do tipo aluno
            EntidadeContextoGenerico.Salvar(professor); // Passando para o metodo salvar um objeto do tipo professor
            EntidadeContextoGenerico.Salvar(diretor); // Passando para o metodo salvar um objeto do tipo diretor
        }
    }


    public class ContextoDados<T> // classe generica do tipo T de type, para qualquer entidade
    {
        public void Salvar(T modelo)
        {
            System.Console.WriteLine("\nSalvando!!!!");
        }
    }

    public class ContextoDados<PE, AL, PR> // classe generica do tipo PE, AL, PR, para 3 tipos de entidade
    {
        public void Salvar(PE modelo)
        {
            System.Console.WriteLine("\nSalvando Pessoa!!!!");
        }
        public void Salvar(AL modelo)
        {
            System.Console.WriteLine("\nSalvando Aluno!!!!");
        }

        public void Salvar(PR modelo)
        {
            System.Console.WriteLine("\nSalvando Professor!!!!");
        }
    }

    public class ContextoDadosGenerico<PE, AL, PR, DI> // limitando os tipos genericos da classe do tipo PE, AL, PR, para 3 tipos de entidade
    where PE : Pessoa
    where AL : Aluno
    where PR : Professor
    where DI : IDiretor

    {
        public void Salvar(PE modelo)
        {
            System.Console.WriteLine("\nSalvando Pessoa Generica!!!!");
        }
        public void Salvar(AL modelo)
        {
            System.Console.WriteLine("\nSalvando Aluno Generico!!!!");
        }

        public void Salvar(PR modelo)
        {
            System.Console.WriteLine("\nSalvando Professor Generico!!!!");
        }

        public void Salvar(DI modelo)
        {
            System.Console.WriteLine("\nSalvando Diretor Generico!!!!");
        }
    }

    public interface IDiretor { } // Interface Diretor
    public class Pessoa { }
    public class Aluno { }
    public class Professor { }
    public class Diretor : IDiretor { }

}
