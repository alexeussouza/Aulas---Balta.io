using Balta.ContentContext.Enums;

namespace Balta.ContentContext{
    public class Lecture{ // Lectura significa aula

        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
// Todo artigo é um content