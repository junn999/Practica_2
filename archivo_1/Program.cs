﻿using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nota promedio: ");
            double nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                if (nota >= 6.0)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota >= 5.0)
                {
                    Console.WriteLine("Reposicion");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            else
            {
                Console.WriteLine("Nota Invalida");
            }
        }
    }
}
