using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public abstract class Generator
    {
        //public int _oilLevel = 100;
        public bool HasPowerSource { get; set; } = true;
        public string Name { get; set; }
        public int Rating { get; set; }

        public bool HasStarted { get; set; }


        public virtual bool Start()
        {
            //check that it has a powersource but is not yet started
            if (HasPowerSource)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract bool Stop();


    }


}
