using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public class Leon : Animal
    {
        public Leon(int edad, double peso, double altura, int cantidadDeLaManada) : base(edad, peso, altura)
        {
            CantidadDeLaManada = cantidadDeLaManada;
        }

        public int CantidadDeLaManada { get; set; }

        public override string ImprimirPropiedades()
        {
            return "Edad: " + Edad + " \nPeso: " + Peso + " \nAltura: " + Altura + "\nCantidad de la manada: " + CantidadDeLaManada;
        }
        public override string ImprimirComida()
        {
            return "\nImprime comida: Carne";
        }
    }
}
