using Balta.ContentContext.Enums;

namespace Balta.ContentContext{

    public class Course : Content{

        public Course(string title, string url)
            :base(title, url)
        {
            Modules = new List<Module>();  // Inicialização da lista de Modulos    
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; } // Necessario inicializar a lista de modulos no construtor

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
// Todo artigo é um content