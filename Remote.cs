using System;

namespace Adapter
{
    class Remote : IRemote
    {
        public void TurnOffTV(ITV tv)
        {
            tv.TurnOff();
        }
        public void TurnOnTV(ITV tv)
        {
            tv.TurnOn();
        }
    }
}