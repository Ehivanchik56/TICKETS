using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Passangers
    {
        [Key]
        public int IdPassanger { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
