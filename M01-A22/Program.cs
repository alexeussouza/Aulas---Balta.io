using System;
class Program
{
    static void Main(string[] args)
    {
        var room = new Room(3); // Room recebe a quantidade de assentos disponiveis na sala

        room.RoomSoldOutEvent += OnRoomSoldOut; // Delegando RoomSoldOutEvent para o metodo OnRoomSoldOut, sempre que o evento for disparado este metodo será chamado
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat(); // reserva chamada 3 vezes para testar o metodo!!!
    }

    static void OnRoomSoldOut(object sender, EventArgs e) // Metodo delegado para manipular o evento
    {
        System.Console.WriteLine("\nSala cheia!!!!\n");
    }
}
public class Room
{
    private int seatsInUse = 0;
    public int Seats { get; set; }
    public Room(int seats) // Construtor da classe, recebe o paramentro na chamada  de Room() na classe principal
    {
        Seats = seats; // Seats recebe a quantidade de assentos informado na chamada do metodo na Main
        seatsInUse = 0;
    }
    public void ReserveSeat()
    {
        seatsInUse++; // Quantidade de assentos incrementada
        if (seatsInUse >= Seats) // quando a quantidade de assentos em uso for igual a quantidade de assentos disponiveis, evento OnRoomSoldOut() será chamado
        {
            OnRoomSoldOut(EventArgs.Empty); // EventArgs vazio, pois neste exemplo nenhuma informação extra será necessaria.
            // Iniciar o nome de eventos com AoAconteceralgo, exemplo AoClicar(), AoFicarSalaCheia(), AoChegarFInalArquivo()
        }
        else
        {
            System.Console.WriteLine("\nAssento reservado");
        }
    }
    public event EventHandler RoomSoldOutEvent; // RoomSoldOutEvent é do tipo evento e EventHandler é o manipulador deste evento
    //RoomSoldOut ocorre este evento sempre que a sala estiver cheia.
    protected virtual void OnRoomSoldOut(EventArgs e) // Metodo manipulador do evento RoomSoldOutEvent
    {
        EventHandler handler = RoomSoldOutEvent; // handler é do tipo manipulador de eventos e recebe RoomSoldOutEvent, será delegado para outra função
        handler.Invoke(this, e); // Invoke invoca o evento RoomSoldOut. Invoke precisa de (Object sender, Eventargs e)
    }
}