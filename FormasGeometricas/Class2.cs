using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometricas
{
    class Circulo : Forma
    {
        public Circulo(double raio, Cor cor) : base(cor) //Construtor com parametros
        {
            Raio = raio;
        }
        public override double Area() //Calcula a area
        {
            return Math.PI * Raio * Raio;
        }
    }
}
