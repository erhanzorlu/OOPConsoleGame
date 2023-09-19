using OOPConsoleGame.Interfaces;
using OOPConsoleGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Irk irk = new Irk("insan");
            Sinif s=new Sinif("savasci");
        
           

            Karakter k = new Karakter(s,irk);

            Console.WriteLine("Yakın Saldırı: "+k.YakinSaldiri());
            Console.ReadLine();

            List<IStat> statBelirle = new List<IStat>
            {
                new Irk(""),
                new Sinif("")
            };
        }
    }
}
