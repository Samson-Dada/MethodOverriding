using System;

namespace Overriding
{
    public class Mikano2 : Generator

    {
        public int _oilLevel;
        public Mikano2()
        {
        _oilLevel = 100;
         
        }

    public override bool Start()
    {
        if(_oilLevel < 50)
        {
            Console.WriteLine("Oil level too low");
            return false;
        }
        else 
        {
          var started = base.Start();
                if (started) 
                {
                    _oilLevel--;
                    return true;
                }
                else 
                {
                    return true;
                }
        }

    }
        public override bool Stop()
        {
            if (HasStarted) 
            {
                HasStarted = false;
                return true; 
            }
            else return false;
        }




        public void RefilOilLevel()
        {

            if (_oilLevel < 50)
            {
                Console.WriteLine($"Refiling oil now....");
            _oilLevel = 100;

            } 

        }

    }
}
