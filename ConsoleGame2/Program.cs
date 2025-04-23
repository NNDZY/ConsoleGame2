using ConsoleGame2.PlayingGame;
using ConsoleGame2.Map;

namespace ConsoleGame2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Random random = new Random();

            CMap map = new CMap();

            CMap.WindowSet();

            CMap.MainPage();     //시작화면

            CPlayingGame.StartGame();       //static은 클래스로 직접 접근해야함
            //CPlayingGame.RestartGame();

           






        }
    }
}
