using System;
using System.Collections.Generic;
using System.Globalization;

namespace FormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Forma> list = new List<Forma>(); //Lista das formas
            Console.Write("Entre com o número de formas: "); //Quantidade de formas
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Círculo (R/C)? "); //Retângulo ou Círculo
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): "); //A cor
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                if (ch == 'R') //Retangulo
                {
                    //Adiciona altura e largura na lista
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else //Circulo
                {
                    //Adiciona raio na lista
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
            }
            //Escrever a área de cada forma
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
