using System.Collections.Generic;


namespace Balta.ContentContext{

    public class Module{

        public Module()
        {
            Lectures = new List<Lecture>();  // Inicialização da lista de Modulos    
        }

        public int Order { get; set; } // ordem dos modulos

        public string Title { get; set; } // titulo do modulo

        public IList<Lecture> Lectures {get; set;}
    }
}



