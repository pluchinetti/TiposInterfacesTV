namespace Adapter
{
    interface ISmartTV : ITV
    {
        void PlayNetflix();
        void PlayYouTube();
    }
}