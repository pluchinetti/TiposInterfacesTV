using System;

namespace Adapter
{
    class SmartRemote : ISmartRemote, IRemote
    {
        public void TurnOffTV(ITV tv)
        {
            tv.TurnOff();
        }
        public void TurnOnTV(ITV tv)
        {
            tv.TurnOn();
        }
        public void StartNetflix(ISmartTV smartTV)
        {
            smartTV.PlayNetflix();
        }
        public void StartYouTube(ISmartTV smartTV)
        {
            smartTV.PlayYouTube();
        }
    }
}