using System;
namespace Overriding
{
    public class Mikano : Generator
    {
        private int _oilLevel;

        public override bool Start()
        {
            if(_oilLevel <= 50)
            {
                return false;
            }
            return base.Start();    
        
        }
        public override bool Stop()
        {
            return false;
        }
    }


}
