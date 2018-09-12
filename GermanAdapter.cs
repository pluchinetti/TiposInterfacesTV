namespace Adapter
{
    class GermanAdapter: ITV
    {
        private GermanTV germanTV;

        public bool Status
        {
            get
            {
                if (germanTV.Status=="eingeschaltet")
                    return false;
                else
                    return true;
            }
            
        }
        private GermanTV GermanTV;

        public GermanAdapter(GermanTV germanTV)
        {
            this.germanTV = germanTV;
        }

        public void TurnOn()
        {
            germanTV.Einschalten();
        }
        public void TurnOff()
        {
            germanTV.Ausschalten();
        }
    }
}