﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleGame.Models
{
    internal class Sehir:BaseEntity
    {
        public List<Irk> Irklar { get; set; }
        public Bolge Bolge { get; set; }

    }
}
