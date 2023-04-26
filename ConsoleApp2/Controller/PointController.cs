using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    internal class PointController
    {
        ApplicationsContext ef = new ApplicationsContext();

        public void AddPoint()
        {
            Console.WriteLine("Введите название города");

            Point point = new Point() { Value = Console.ReadLine() };

            ef.Add(point);
            ef.SaveChanges();
        }
    }
}
