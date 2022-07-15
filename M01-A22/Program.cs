class Program{

    static void Main(string[] args)
    {
        var room = new Room(3);


        System.Console.WriteLine( "Programa principal");
    }

    public class Room
    {
        
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {

            seatsInUse++;
            if(seatsInUse >= Seats)
            {
                //Evento fechado!
            }
            else
            {
                System.Console.WriteLine("Assento reservado");
            }  
        }
        public event EventHandler RoomSoldOut; // event é do tipo evento e EventHandler é o manipulador de eventos
    }
}