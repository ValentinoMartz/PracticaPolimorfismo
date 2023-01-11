using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Loro : Animal
    {
        public Loro(int edad, double peso, double altura, bool habla) : base(edad, peso, altura)
        {
            Habla = habla;
        }
        public bool Habla { get; set; }

        public override string ImprimirPropiedades()
        {
            return "Edad: " + Edad + " \nPeso: " + Peso + " \nAltura: " + Altura + "\nHabla: " + (Habla ? "Si" : "NO");
        }
        public override string ImprimirComida()
        {
            return "\nImprime comida: Semillas";
        }
    }
}
