using System;

namespace tarea_calculadora
{
    class Program
    {
        static int num1 = 0, num2 = 0;
        static void Main(string[] args)
        {
            int option;
            bool ejecutar = true;
            Console.WriteLine("CALCULADORA DE OPERACIONES BASICAS");
            Console.WriteLine(" ");
            do
            {
                Console.WriteLine("Elige una de las opciones");
                Console.WriteLine(" ");
                Console.WriteLine("1. SUMAR");
                Console.WriteLine("2. RESTAR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("5. PRESIONA 0 PARA SALIR");
                Console.WriteLine(" ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado de la suma es: {Suma(num1, num2)}");
                        break;

                    case 2:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado de la resta es: {Resta(num1, num2)}");
                        break;

                    case 3:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado de la multiplicación es: {Multi(num1, num2)}");
                        break;

                    case 4:
                        SolicitarDatos();
                        Console.WriteLine($"El resultado de la división es: {Div(num1, num2)}");
                        break;

                    case 0:
                        ejecutar = false;
                        break;

                    default:
                        Console.WriteLine("ERROR INTENTALO DE NUEVO");
                        break;
                }
            } while (ejecutar);                 
        }
        static void SolicitarDatos()
        {
            Console.WriteLine("Ingresa el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el primer número: ");
            num2 = int.Parse(Console.ReadLine());
        }

        static int Suma(int num1, int num2) => num1 + num2;
        static int Resta(int num1, int num2) => num1 - num2;
        static int Multi(int num1, int num2) => num1 * num2;
        static double Div(int num1, int num2) => Convert.ToDouble(num1) / Convert.ToDouble(num2);

    }
}