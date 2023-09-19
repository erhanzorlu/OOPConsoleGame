﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal abstract class KarakterYaratikSpec:BaseEntity
    {
       
        public virtual int MaksimumCan { get; set; }
        public int MevcutCan { get; set; }
        public virtual int MaksimumEnerji { get; set; }
        public int MevcutEnerji { get; set; }
        public virtual int TecrubePuani { get; set; }


        public virtual int YakinSaldiri()
        {

            Random rnd = new Random();
            return rnd.Next(1,21);
        }
        public abstract void OzelSaldiri();
        
    }
}
