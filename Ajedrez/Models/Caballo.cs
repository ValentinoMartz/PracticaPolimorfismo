﻿using Ajedrez.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Models
{
    public class Caballo : PiezaAjedrez
    {
        public Caballo() { }

        public override string Mover()
        {
            return "Se mueve en L";
        }
    }
}
