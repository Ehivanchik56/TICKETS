using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    internal class PassangersController
    {
        ApplicationsContext ef = new ApplicationsContext();
        public void AddPassanger()
        {
            Console.WriteLine("Введите имя + номер пассажира ");
            Passangers passangers = new Passangers()
            {
                Name = Console.ReadLine(),
                Phone = Console.ReadLine(),
            };

            ef.Add(passangers);
            ef.SaveChanges();
        }

        public void EditPassangerName()
        {
            Console.WriteLine("Введите имя пассажира , которого нужно изменить");
            var OldName = ef.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine());

            if (OldName != null)
            {
                Console.WriteLine("Введите новое имя пассажира");
                OldName.Name = Console.ReadLine();
            }
            ef.SaveChanges();
        }
        public void ShowPassangers()
        {
            foreach (var item in ef.Tickets.Include(x => x.Passanger).Include(x => x.PointArrival).Include(x => x.PointDeparture).ToList())
            {
                Console.WriteLine($"{item?.IdTicket}, {item.Passanger?.Name}, время отправления - {item.PointDeparture?.Value}-{item.PointArrival?.Value}, время прибытия - {item.DateArrive}");
            }
        }
    }
}
