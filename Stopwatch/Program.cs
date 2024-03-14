using System;
using System.Globalization;
using System.Threading;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("S para segundos = 10s");
            System.Console.WriteLine("M para minutos = 1m");
            System.Console.WriteLine("0s para sair");
            System.Console.WriteLine("Quanto tempo deseja contar?");
            System.Console.WriteLine();

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Console.WriteLine("Obrigado por usar o cronómetro");
                System.Environment.Exit(0);
            }

            Start(time * multiplier);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            System.Console.WriteLine("Stopwatch finalizado");
            Menu();
        }

    }

}






