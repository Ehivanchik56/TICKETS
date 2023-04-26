using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Ticket
    {
        [Key]
        public Guid IdTicket { get; set; }
        public Passangers Passanger { get; set; }
        public Point PointDeparture { get; set; } 
        public Point PointArrival { get; set; } 
        public DateTime DateArrive { get; set; } 
    }
}
