﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvadeWPF.Interfaces;

namespace EvadeWPF.Models
{
    class BoardSquare : IBoardItem
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
}