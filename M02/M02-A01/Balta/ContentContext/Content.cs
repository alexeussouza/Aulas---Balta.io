namespace Balta.ContentContext
{

    public abstract class Content
    { // Abstract não permite que esta classe seja instanciada

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public Content()
        {
            Id = Guid.NewGuid(); // geração do Id na chamada do construtor, é incorreto usar new Guid().
        }
    }
}