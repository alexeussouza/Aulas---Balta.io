namespace Balta.ContentContext{

    public class Career : Content{

        public Career(string title, string url)
            :base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public  IList<CareerItem> Items { get; set; }

       /*
        public int TotalCourses { 
            get{
                return Items.Count; 
                // retorna a quantidade de itens, set não foi declarado para não permite setar valor
            }
         }
         */

           public int TotalCourses  => Items.Count; // Expression Body, podemos utilizar esta forma de contar, quando um metodo tiver apenas o get{ return Items.Count}
    }
}