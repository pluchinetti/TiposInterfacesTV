namespace Adapter
{
    class GermanAdapter: ITV
    {
        public bool Status
        {
            get
            {
                if (germanTV.Status=="eingeschaltet")
                    return true;
                else
                    return false;
            }
            
        }
        private GermanTV germanTV;
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