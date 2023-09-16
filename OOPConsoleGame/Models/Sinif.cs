using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Sinif:BaseEntity
    {
        public Sinif(string isim)
        {
            Isim = isim;
        }
        public List<Karakter> Karakterler {  get; set; }    
    }
}
