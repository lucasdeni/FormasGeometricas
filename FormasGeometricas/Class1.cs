using System;
using System.Collections.Generic;
using System.Text;

enum Cor //Cores da forma
{
    Preto,
    Azul,
    Vermelho
}
namespace FormasGeometricas
{
    abstract class Forma
    {
        //Declaração das variaveis e encapsulamento
        public Cor Color { get; set; } 
        public double Raio { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Forma(Cor color) //Construtor com parametros
        {
            Color = color;
        }
        public abstract double Area(); //Método abstrato
    }
}
