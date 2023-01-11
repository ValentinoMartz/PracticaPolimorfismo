using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales.Animales
{
    public abstract class Animal
    {

        public Animal(int edad, double peso, double altura)
        {
            Edad = edad;
            Peso = peso;
            Altura = altura;
        }

        public int Edad { get; }
        public double Peso { get; }
        public double Altura { get; }
        public abstract string ImprimirComida();

        public virtual string ImprimirPropiedades()
        {
            return "Edad: " + Edad + " Peso: " + Peso + " Altura: " + Altura;
        }

    }
}
