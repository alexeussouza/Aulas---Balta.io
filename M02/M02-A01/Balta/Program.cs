using System;
using System.Linq;
using Balta.ContentContext;
using Balta;

namespace Balta{

    class Program{

        static void Main(string[] args)
        {
            var articules = new List<Article>();
            articules.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articules.Add(new Article("Artigo sobre Testes", "testes-software"));
            articules.Add(new Article("Artigo sobre DIP", "injecao-dependencia"));

            foreach(var item in articules){

                System.Console.WriteLine("\n" + item.Id);
                System.Console.WriteLine(item.Title);
                System.Console.WriteLine(item.URL);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamento-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamento-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamento-aspnet");
            
            //adicionando cursos no List(Course)
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);  

            if(courseAspNet.IsInvalid){
                // exemplo de verificação para o objeto
            }

          

            var careers = new List<Career>(); // criando um novo List() de carreira
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet"); // criando uma nova carreira
            
            var careerItem2 = new CareerItem(2, "Segundo Passo, Aprenda .Net", "", null); // criando um novo item de carreira
            var careerItem3 = new CareerItem(3, "Terceiro Passo, Aprenda OOP", "", null); // criando um novo item de carreira
            var careerItem1 = new CareerItem(1, "Primeiro Passo, comece por aqui", "", courseAspNet); // criando um novo item de carreira
                                
            careerDotnet.Items.Add(careerItem3); // itens foram adicionados desta forma para ser organizado atraves do item.OrderBy no Foreach()
            careerDotnet.Items.Add(careerItem2); // adicionando item para carreira
            careerDotnet.Items.Add(careerItem1); // adicionando item para carreira
            
            careers.Add(careerDotnet); // adicionando carreira no List(Career)

            foreach(var career in careers){

                System.Console.WriteLine("\n" + career.Id);
                System.Console.WriteLine($"{career.Title} - {career.URL}");

                foreach(var item in career.Items.OrderBy(x =>x.Order)) 
                // Organizado Items atraves do item.OrderBy, para ficar descrecente usar OrderByDescending(), 
                // usar o x função x =>x.Order para ter acesso as propriedades do objeto.
                { 
                    System.Console.WriteLine($"{item.Order} -  {item.Title}"); // composição de string  ($"{item.Order} -  {item.Title}");
                    System.Console.WriteLine($"{item.Course?.Title}");
                    System.Console.WriteLine($"{item.Course?.Level}");

                    foreach(var notification in item.Notifications){
                        System.Console.WriteLine($"{notification.Property} - {notification.Message}"); // notificação exibida e aplicação não foi encerrada
                    }
                }
            }
            
            System.Console.WriteLine("\n====> Final do Programa <====\n");
        }
    }
}
