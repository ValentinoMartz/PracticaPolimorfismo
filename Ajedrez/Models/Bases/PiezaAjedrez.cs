using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez.Models.Bases
{
    public abstract class PiezaAjedrez
    {
        public PiezaAjedrez()
        {
        }

        public abstract string Mover();

    }
}
