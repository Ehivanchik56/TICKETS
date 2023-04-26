using ConsoleApp2.Controller;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру для выбора действия" +
                "\n1-добавить пассажира" +
                "\n2-изменить имя пассажира" +
                "\n3-добавить билет" +
                "\n4-удалить билет" +
                "\n5-добавить город" +
                "\n6-показать пассажиров");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    PassangersController pascontrol = new PassangersController();
                    pascontrol.AddPassanger();
                    break;
                case "2":
                    PassangersController pascontrol2 = new PassangersController();
                    pascontrol2.EditPassangerName();
                    break;
                case "3":
                    TicketController ticketcontrol = new TicketController();
                    ticketcontrol.AddTicket();
                    break;
                case "4":
                    TicketController ticketcontrol2 = new TicketController();
                    ticketcontrol2.DeleteTicketByName();
                    break;
                case "5":
                    PointController pointcontrol = new PointController();
                    pointcontrol.AddPoint();
                    break;
                case "6":
                    PassangersController pascontrol3 = new PassangersController();
                    pascontrol3.ShowPassangers();
                    break;
            }
            
        }
    }
}