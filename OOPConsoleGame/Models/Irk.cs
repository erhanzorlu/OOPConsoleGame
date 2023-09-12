using OOPConsoleGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    internal class Irk : BaseEntity
    {
        public int GucModifikasyonu { get; set; }
        public int CeviklikModifikasyonu { get; set; }
        public int IradeModifikasyonu { get; set; }
    }
}
