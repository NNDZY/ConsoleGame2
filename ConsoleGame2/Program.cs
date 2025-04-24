using ConsoleGame2.PlayingGame;
using ConsoleGame2.Map;
using ConsoleGame2.Setting;

namespace ConsoleGame2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            

            Random random = new Random();

            CSetting.WindowSet();

            CPlayingGame.StartGame(); 


        }
    }
}
