using System;
using System.Threading;

namespace Overriding
{
    internal class Program
    {
        static void Main()
        {

            Mikano2 mikano = new();
            for( int i = 100; i >= 0; i--) 
            {
                mikano.Start();
                Console.WriteLine($"Current oil level: {mikano._oilLevel}");
                if ( mikano._oilLevel < 50)
                {
             
               mikano.RefilOilLevel();
                    Console.WriteLine($"Generator oil level is now : {mikano._oilLevel}");
                }

                Thread.Sleep(100);
                
            }
        }
        

    }
}
