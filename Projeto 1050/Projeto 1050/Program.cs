﻿using System;
using System.Globalization;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            double A;

            A = double.Parse(Console.ReadLine());

            if (A == 61)
            {
                Console.WriteLine("Brasilia");

            }
            else if (A == 71)
            {
                Console.WriteLine("Salvador");

            }
            else if (A == 11)
            {
                Console.WriteLine("Sao Paulo");

            }
            else if (A == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (A == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (A == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (A == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (A == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }

            else
            {
                Console.WriteLine("DDD nao cadastrado");

            }

            //Console.ReadLine();

        }

    }
}
