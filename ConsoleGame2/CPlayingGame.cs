using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame2.Map;
using ConsoleGame2.Setting;
using ConsoleGame2.Pet;
using ConsoleGame2.Player;
using System.Drawing;
using System.Threading;

namespace ConsoleGame2.PlayingGame
{
    internal class CPlayingGame : CMap
    {
        public static void StartGame()
        {
            Console.Clear();

            MainPage();     //시작화면

            Console.Clear();

            CPlayingGame playingGame = new CPlayingGame();
            CPet pet = new CPet();


            Thread.Sleep(1000);
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();    //스탑워치 객체
            stopwatch.Start();      //스탑워치 시작

            PlayPage();       //이미지를 띄우고, 요구를 같이 표시
             
            Task task1 = CSetting.GameTimer1();
            Task task2 = CSetting.GameTimer2();

            while (true)
            {
                Console.SetCursorPosition(85, 23);
                Console.Write("               ");
                Console.SetCursorPosition(85, 23);
                pet.ShowPoint();           //좌하단에 점수 표기


                pet.ShowNeeds();    //펫이 행동을 보여준다
                pet.InputNeeds();
                //player.InputNeeds();   //플레이어가 입력한다


               if (stopwatch.ElapsedMilliseconds >= 30000) //30초가 되면 끝
               {
                    FinishPage();
                    stopwatch.Stop();                 

                   Console.SetCursorPosition(50, 15);

                   //결과창
                   pet.ShowPoint();
                   pet.ShowResult();
                   Thread.Sleep(1000);

                   RestartGame();
                   break;
               }

            }

        }

        public static void RestartGame()
        {
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("다시 시작하기 (스페이스바)");
            Console.SetCursorPosition(50, 19);
            Console.WriteLine("게임 종료 (엔터)");
            ConsoleKeyInfo restartKey = Console.ReadKey();

            switch (restartKey.Key)
            {
                case ConsoleKey.Spacebar:
                    Console.SetCursorPosition(50, 21);
                    Console.WriteLine("게임을 다시 시작합니다.");
                    Thread.Sleep(1000);
                    StartGame();
                    break;
                case ConsoleKey.Enter:
                    Console.SetCursorPosition(50, 21);
                    Console.WriteLine("게임을 종료합니다.");
                    Console.SetCursorPosition(50, 30);
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
