using static System.Console;
namespace GeneralLibrary
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is paussing");
        }

        public void Play()
        {
            WriteLine("DVD player is playing");
        }

        public void Stop()
        {
            WriteLine("DVD is stopping");
        }
    }
}