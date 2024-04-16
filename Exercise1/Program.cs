using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fuel_tank tank = new Fuel_tank(1000);
            Engine eng = new Engine();
            Console.Out.WriteLine("Amount: " + tank.GetAmount());
            Console.Out.WriteLine("+100 Amount");
            tank.Fill(100);
            Console.Out.WriteLine("Amount: " + tank.GetAmount());
            Console.Out.WriteLine("Fuel Lvl: " + tank.GetLevel() + "%");

            eng.Start();
            Console.Out.WriteLine("State: " + eng.GetState());
            Thread.Sleep(2000);
            Console.Out.WriteLine();

            eng.Stop();
            Console.Out.WriteLine("State:" + eng.GetState());

            Console.ReadKey();
        }
    }
}
