using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Bolge:BaseEntity
    {
        public float KoordinatX { get; set; }
        public float KoordinatY { get; set; }
        public int MyProperty { get; set; }
        public List<Sehir> Sehirler { get; set; }
        public Kita Kitasi { get; set; }
  
    }
}
