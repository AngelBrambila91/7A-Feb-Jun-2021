using static System.Console;
namespace GeneralLibrary
{
    public interface IPlayable
    {
         void Play();
         void Pause();
         void Stop()
         {
             WriteLine("Default Implementation of Stop.");
         }
    }
}