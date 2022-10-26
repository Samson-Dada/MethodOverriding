

namespace Overriding
{
    public class Lister : Generator
    {
        public bool HasStarterEaten { get; set; }

        public override bool Start()
        {
            //check if the starter has eaten and that the generator has not started
            if (HasStarterEaten && HasStarted)
            {
                var started = base.Start();
                if (started)
                {
                    HasStarted = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override bool Stop()
        {
            if (HasStarted) 
            {
                return Stop();
            }
            return true;
        }


    }



}



