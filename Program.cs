using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double doubleBase;
            double doubleAltura;
            double doubleArea;
            double doubleLadoA;
            double doubleLadoB;
            double doubleLadoC;
            double doubleSP;

            int intNum;
            Console.WriteLine("Calculando a área de 3 tipos de triangulos diferentes");
            Console.WriteLine("1 . Area to triangulo escaleno: "); // os 3 lados diferentes
            Console.WriteLine("2 . Area to triangulo equilatero: "); // os 3 lados iguais
            Console.Write("Escolha uma da opções:  "); 

            intNum = Convert.ToInt32( Console.ReadLine());
         
            if (intNum < 1 ^ intNum >2)
            {
            Console.WriteLine("Opção Invalida - execute o programa novamente");
            }
            if (intNum == 1)
            {
            
            Console.WriteLine("Você escolheu Saber a área e o semiperimetro do - Triagulo Escaleno.");

            Console.Write("Digite o 1º lado :");
            doubleLadoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2º lado :");
            doubleLadoB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 3º lado :");
            doubleLadoC = Convert.ToDouble(Console.ReadLine());
            
            doubleSP = (doubleLadoA + doubleLadoB + doubleLadoC) / 2;
            //Calculo da área p.(p-a).(p-b).(p-c)
            doubleArea = Math.Sqrt(doubleSP*(doubleSP - doubleLadoA) * (doubleSP - doubleLadoB) * (doubleSP - doubleLadoC) ); 

            Console.Write($" Lado A {doubleLadoA}\n Lado B {doubleLadoB}\n Lado C {doubleLadoC}\n Semiperimetro é: {doubleSP}\n Área é: {doubleArea:N2}");
            }
            if (intNum == 2)
            {
            Console.WriteLine("Você escolheu Saber a área e o semiperimetro do - Triagulo Equilatero.");
            Console.Write("Digite o 1º lado :");
            doubleLadoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2º lado :");
            doubleLadoB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 3º lado :");
            doubleLadoC = Convert.ToDouble(Console.ReadLine());
            
            doubleSP = (doubleLadoA + doubleLadoB + doubleLadoC) / 2;
            //Calculo da área p.(p-a).(p-b).(p-c)
            doubleArea = (doubleLadoA * doubleLadoA) * Math.Sqrt(3)/4; 

            Console.Write($" Lado A {doubleLadoA}\n Lado B {doubleLadoB}\n Lado C {doubleLadoC}\n Semiperimetro é: {doubleSP}\n Área é: {doubleArea:N2}");
            }
            //if (intNum == 2)
            }
        }
    }

