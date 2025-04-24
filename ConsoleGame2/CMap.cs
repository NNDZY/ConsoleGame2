using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame2.Image;

namespace ConsoleGame2.Map
{
    internal class CMap
    {
        public static void MainPage()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            Console.SetCursorPosition(0, 36);
            Console.Write(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("강아지 돌보기");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("  게임 방법 : 강아지를 돌보면서 점수를 얻으세요");
            Console.WriteLine("  강아지가 원하는 행동에 맞게 방향키를 누르면 됩니다.");
            Console.WriteLine("  맞으면 100점을 얻고, 잘못 입력할경우 100점을 잃게 됩니다.");
            Console.WriteLine("");
            Console.WriteLine("  제한시간은 30초입니다.");
            Console.WriteLine("");
            Console.Write("  시작하려면 엔터를 눌러주세요");
            Console.ReadLine();
            //StartGame();
        }

        public static void PlayPage()        //화면 위에 고정하고 표시
        {
            CImage.PetImg(4, 4);

            Console.SetCursorPosition(60, 4);
            Console.WriteLine($"\t┌─────────────────────┐\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t└─────────────────────┘\n");

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            CImage.FoodImg(3, 28);
            CImage.HugImg(27, 28);
            CImage.WashImg(52, 28);
            CImage.PlayImg(77, 28);

            Console.SetCursorPosition(0, 38);
            Console.Write(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
        }
        public static void FinishPage()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 2);
            Console.WriteLine(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
            Console.SetCursorPosition(0, 36);
            Console.Write(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
        }
    }
}