﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    
    // todo:30.17
    internal class Zindan
    {
        public Bolge Bolge { get; set; }
        public Sehir Sehir { get; set; }
        public List<Yaratik> Yaratiklar { get; set; }
        public List<ElitYaratik> ElitYaratiklar { get; set; }
    } 
}
