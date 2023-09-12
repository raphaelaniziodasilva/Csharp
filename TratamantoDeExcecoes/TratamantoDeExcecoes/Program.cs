using TratamantoDeExcecoes.Entties;

namespace TratamantoDeExcecoes {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Room number: ");
            int roomNumber  = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            // create reservation
            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

        }
    }
}