using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    internal class TicketController
    {
        ApplicationsContext ef = new ApplicationsContext();

        public void AddTicket()
        {
            Console.WriteLine("Напишите имя, город отправления и город прибытия");
            Ticket ticket = new Ticket()
            {
                Passanger = ef.Passangers.FirstOrDefault(x => x.Name == Console.ReadLine()),
                PointDeparture = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                PointArrival = ef.Points.FirstOrDefault(x => x.Value == Console.ReadLine()),
                DateArrive = DateTime.Now.AddHours(6)
            };

            ef.Add(ticket);
            ef.SaveChanges();
        }

        public void DeleteTicketByName()
        {
            Console.WriteLine("Введите имя для удаления билета");
            string NameToRemove = Console.ReadLine();

            foreach (var items in ef.Tickets.Include(x => x.Passanger))
            {
                if (items.Passanger.Name == NameToRemove)
                {
                    ef.Remove(items);
                }
            }
            ef.SaveChanges();
        }
    }
}
