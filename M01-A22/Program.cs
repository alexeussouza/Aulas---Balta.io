class Program
{

    static void Main(string[] args)
    {
        var room = new Room(3);

        room.RoomSoldOutEvent += OnRoomSoldOut; // Delegando OnRoomSoldOut para o metodo OnRoomSoldOut, sempre que o evento for disparado este metodo será chamado
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat(); // reserva chamada 3 vezes para testar o metodo!!!

    }

    static void OnRoomSoldOut(object sender, EventArgs e) // Evento delegado para este metodo
    {

        System.Console.WriteLine("\nSala cheia!!!!\n");
    }
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
        if (seatsInUse >= Seats) // quando a quantidade de assentos em uso for igual a quantidade de assentos disponiveis, evento será chamado
        {
            OnRoomSoldOut(EventArgs.Empty); // EventArgs vazio, pois neste exemplo nenhuma informação extra será necessaria.
        }
        else
        {
            System.Console.WriteLine("\nAssento reservado");
        }
    }
    public event EventHandler RoomSoldOutEvent; // event é do tipo evento e EventHandler é o manipulador de eventos
                                                //RoomSoldOut ocorre este evento sempre que a sala estiver cheia.

    protected virtual void OnRoomSoldOut(EventArgs e) // Manipulador do evento RoomSoldOut
    {
        EventHandler handler = RoomSoldOutEvent; // handler é do tipo manipulador de eventos e recebe RoomSoldOut, será delegado para outra função
        handler?.Invoke(this, e); // Invoke invoca o evento RoomSoldOut. Invoke precisa de (Object sender, Eventargs e)
    }
}
