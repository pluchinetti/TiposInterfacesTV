using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITV tv = new TV();
            IRemote rem = new Remote();
            rem.TurnOnTV(tv);
            rem.TurnOffTV(tv);

            ISmartTV stv = new SmartTV();
            rem.TurnOnTV(stv);
            rem.TurnOffTV(stv);
            rem.TurnOnTV(stv);

            ISmartRemote srem = new SmartRemote();
            srem.StartNetflix(stv);
            srem.StartYouTube(stv);

            GermanTV gtv = new GermanTV();
            rem.TurnOnTV(gtv);
            rem.TurnOffTV(gtv);
        }

    }
}
