using System;

namespace Adapter
{
    class TV : ITV
    {
        public bool Status {get;private set;}

        public void TurnOff()
        {
            this.Status = false;
        }

        public void TurnOn()
        {
            this.Status = true;
        }
    }
}