using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Conejo : Animal
    {
        public Conejo(int edad, double peso, double altura, string color) : base(edad, peso, altura)
        {
            Color = color;
        }
        public string Color { get; set; }

        public override string ImprimirPropiedades()
        {
            return "Edad: " + Edad + " \nPeso: " + Peso + " \nAltura: " + Altura + "\nColor: " + Color;
        }
        public override string ImprimirComida()
        {
            return "\nImprime comida: Zanahoria";
        }
    }
}
