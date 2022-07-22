namespace Balta.ContentContext{

    
    public class Article : Content{ 

        public Article(string title, string url) 
            :base(title, url) // passando os parametros para o construtor da classe pai com base
        {
            
        }



    }
}
// Todo artigo é um content