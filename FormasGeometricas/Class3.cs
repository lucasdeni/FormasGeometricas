using System;
using System.Collections.Generic;
using System.Text;

namespace FormasGeometricas
{
    class Retangulo : Forma
    {
        public Retangulo(double largura, double altura, Cor cor) : base(cor) //Construtor com parametros
        {
            Largura = largura;
            Altura = altura;
        }
        public override double Area() //Calcula a area
        {
            return Largura * Altura;
        }
    }
}
