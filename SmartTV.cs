namespace Adapter
{
    class SmartTV : ISmartTV
    {
        public bool Status {get;private set;}
        private bool playingNetflix = false;
        private bool playingYouTube = false;

        public void PlayNetflix()
        {
            if (this.Status)
            {
                this.playingNetflix = true;
                this.playingYouTube = false;
            }
        }

        public void PlayYouTube()
        {
            if (this.Status)
            {
                this.playingNetflix = false;
                this.playingYouTube = true;
            }
        }
        
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
