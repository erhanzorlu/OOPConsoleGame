using OOPConsoleGame.Interfaces;
using OOPConsoleGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame
{
    internal class Irk : BaseEntity,IStat
    {
        public Irk(string isim)
        {
            Isim = isim;
            switch (Isim.ToLower())
            {
                case "insan":
                    IradeModifikasyonu = 1;
                    break;

                case "ork":
                    DayaniklilikModifikasyonu = 2;
                    break;

                case "elf":
                    CeviklikModifikasyonu = 1;
                    break;

                case "cuce":
                    GucModifikasyonu = 2;
                    break;

                case "undead":
                    GucModifikasyonu = 3;
                    IradeModifikasyonu = 1;
                    break;
            }
        }

        public void StatBelirle(Karakter k)
        {
            switch (Isim.ToLower())
            {
                case "insan":
                    k.Irade += IradeModifikasyonu;
                    break;

                case "ork":
                    k.Dayaniklilik += DayaniklilikModifikasyonu;
                    break;

                case "elf":
                    k.Ceviklik += CeviklikModifikasyonu;
                    break;

                case "cuce":
                    k.Guc += GucModifikasyonu;
                    break;

                case "undead":
                    k.Guc += GucModifikasyonu;
                    k.Irade += IradeModifikasyonu;
                    break;
                default:
                    break;
            }
        }

   

        public int GucModifikasyonu { get; set; }
        public int CeviklikModifikasyonu { get; set; }
        public int IradeModifikasyonu { get; set; }
        public int DayaniklilikModifikasyonu { get; set; }

        public List<Karakter> Karakterler { get; set; } 

        public Sehir BaslangicSehri { get; set; }
    }
}
