using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame2.Map
{

    internal class CMap
    {
        //윈도우창 사이즈 100*40
        public static void WindowSet()
        {
            Console.SetWindowSize(100, 40);
        }

        public static void MainPage()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            Console.SetCursorPosition(0, 36);
            Console.Write(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("강아지 놀아주기");
            Console.WriteLine("");
            Console.WriteLine("  방향키로 강아지가 원하는 행동을 할 수 있습니다.");
            Console.WriteLine("  맞으면 100점을 얻고, 잘못 입력할경우 100점을 잃습니다.");
            Console.WriteLine("  제한시간은 30초입니다.");
            Console.WriteLine("");
            Console.Write("  게임을 시작하려면 엔터를 눌러주세요");
            Console.ReadLine();
        }


        public static void PlayPage()        //화면 위에 고정하고 표시
        {
            PetImg(4, 4);

            Console.SetCursorPosition(60, 4);
            // Console.WriteLine($"\t┌───────────┐\n\t\t\t\t\t\t│□□□□□□□□□□□│\n\t\t\t\t\t\t│    {needs} │\n\t\t\t\t\t\t│□□□□□□□□□□□│\n\t\t\t\t\t\t└───────────┘\n");
            Console.WriteLine($"\t┌─────────────────────┐\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t└─────────────────────┘\n");


            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

            FoodImg(0, 28);
            HugImg(25, 28);
            WashImg(50, 28);
            PlayImg(75, 28);


            Console.SetCursorPosition(0, 38);
            Console.Write(" 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");

        }

        public static void PetImg(int a, int b)
        {
            //17*17
            //Console.WriteLine("  □■▦");     
            Console.SetCursorPosition(a, b);
            Console.WriteLine("           ■■              ■■  ");
            Console.SetCursorPosition(a, b +1);
            Console.WriteLine("         ■▦▦■          ■▦▦■");
            Console.SetCursorPosition(a, b + 2);
            Console.WriteLine("         ■▦□▦■      ■▦▦□■");
            Console.SetCursorPosition(a, b + 3);
            Console.WriteLine("         ■▦□▦■■■■▦▦□□■");
            Console.SetCursorPosition(a, b + 4);
            Console.WriteLine("         ■▦□▦▦▦□□▦▦□▦■");
            Console.SetCursorPosition(a, b + 5);
            Console.WriteLine("         ■▦▦▦▦▦□□▦▦▦■  ");
            Console.SetCursorPosition(a, b + 6);
            Console.WriteLine("         ■▦▦▦▦▦□□▦▦▦■  ");
            Console.SetCursorPosition(a, b + 7);
            Console.WriteLine("           ■▦▦■▦□□■▦■    ");
            Console.SetCursorPosition(a, b + 8);
            Console.WriteLine("           ■▦▦□□■■□▦■    ");
            Console.SetCursorPosition(a, b + 9);
            Console.WriteLine("             ■□□□□□□□■    ");
            Console.SetCursorPosition(a, b + 10);
            Console.WriteLine("         ■■■▦□□□□▦■      ");
            Console.SetCursorPosition(a, b + 11);
            Console.WriteLine(" ■■  ■▦▦▦▦▦□□▦■        ");
            Console.SetCursorPosition(a, b + 12);
            Console.WriteLine(" ■▦■▦▦▦▦▦▦□□▦■        ");
            Console.SetCursorPosition(a, b + 13);
            Console.WriteLine(" ■▦■▦▦▦▦▦▦□□▦■        ");
            Console.SetCursorPosition(a, b + 14);
            Console.WriteLine(" ■▦■▦▦▦▦▦▦▦▦▦■        ");
            Console.SetCursorPosition(a, b + 15);
            Console.WriteLine("   ■■▦▦▦□■□□■□□■      ");
            Console.SetCursorPosition(a, b + 16);
            Console.WriteLine("     ■■■■■■■■■■■■      ");
        }



        public static void FoodImg(int a, int b)
        {
            Console.SetCursorPosition(a, b);
            Console.WriteLine("↑　　　　　　　　　　");
            Console.SetCursorPosition(a, b+1);
            Console.WriteLine("　　　* *　　　　　　");
            Console.SetCursorPosition(a, b + 2);
            Console.WriteLine("　　*　  * ** *　　　");
            Console.SetCursorPosition(a, b + 3);
            Console.WriteLine("　*　　　  * 　 *　　");
            Console.SetCursorPosition(a, b + 4);
            Console.WriteLine("　*　 * *　 *　 *　　");
            Console.SetCursorPosition(a, b + 5);
            Console.WriteLine("　──────────────　　");
            Console.SetCursorPosition(a, b + 6);
            Console.WriteLine("│　　　　　　　　│　  ");
            Console.SetCursorPosition(a, b + 7);
            Console.WriteLine("│　　　　　　　　│　　");
            Console.SetCursorPosition(a, b + 8);
            Console.WriteLine("　＼　　　　　　／　　");
            Console.SetCursorPosition(a, b + 9);
            Console.WriteLine("　　──────────　　　");
        }


        public static void HugImg(int a, int b)
        {
            Console.SetCursorPosition(a, b);
            Console.WriteLine("↓　_────　♡　　");
            Console.SetCursorPosition(a, b + 1);
            Console.WriteLine("　│＼　  　＼　♡　");
            Console.SetCursorPosition(a, b + 2);
            Console.WriteLine("　│　＼　　  ＼　　");
            Console.SetCursorPosition(a, b + 3);
            Console.WriteLine("　＼　　　 　　＼　");
            Console.SetCursorPosition(a, b + 4);
            Console.WriteLine("　　＼　　　 　　＼　");
            Console.SetCursorPosition(a, b + 5);
            Console.WriteLine("　　　＼　　　　　│　");
            Console.SetCursorPosition(a, b + 6);
            Console.WriteLine("　_────　　　 　　│　");
            Console.SetCursorPosition(a, b + 7);
            Console.WriteLine("*\"　　　　　　　　│　");
            Console.SetCursorPosition(a, b + 8);
            Console.WriteLine("　\"＼ _　　　　　／　");
            Console.SetCursorPosition(a, b + 9);
            Console.WriteLine("　　　　───────　　　");
        }

        public static void WashImg(int a, int b)
        {
            Console.SetCursorPosition(a, b);
            Console.WriteLine("←　　　　　　　　　　");
            Console.SetCursorPosition(a, b + 1);
            Console.WriteLine("　　　* * 　　　　　");
            Console.SetCursorPosition(a, b + 2);
            Console.WriteLine("　　* 　　* 　 * *　　");
            Console.SetCursorPosition(a, b + 3);
            Console.WriteLine("　　* 　*　  *  *　* 　");
            Console.SetCursorPosition(a, b + 4);
            Console.WriteLine("　* ─　* * *　* 　  *　　");
            Console.SetCursorPosition(a, b + 5);
            Console.WriteLine("│　　　* 　　* 　*　　");
            Console.SetCursorPosition(a, b + 6);
            Console.WriteLine("│　　　　* 　　 *│　　");
            Console.SetCursorPosition(a, b + 7);
            Console.WriteLine("│　　　　　* * 　│　　");
            Console.SetCursorPosition(a, b + 8);
            Console.WriteLine(" ＼　　　　　　　／　　");
            Console.SetCursorPosition(a, b + 9);
            Console.WriteLine("　 ─────────────　　");
        }

        public static void PlayImg(int a, int b)
        {
            Console.SetCursorPosition(a, b);
            Console.WriteLine("→　　　 ────　　　");
            Console.SetCursorPosition(a, b + 1);
            Console.WriteLine("　　＊　　　　＊　　");
            Console.SetCursorPosition(a, b + 2);
            Console.WriteLine("　／　＊　　＊　＼　");
            Console.SetCursorPosition(a, b + 3);
            Console.WriteLine(" ／　　＊　＊　  *　　");
            Console.SetCursorPosition(a, b + 4);
            Console.WriteLine("│　　　＊　＊　　│　　");
            Console.SetCursorPosition(a, b + 5);
            Console.WriteLine("│　　　＊　＊　　│　　");
            Console.SetCursorPosition(a, b + 6);
            Console.WriteLine("＊　　＊　　＊   ／　　");
            Console.SetCursorPosition(a, b + 7);
            Console.WriteLine("　＼＊　　　　* ／　　　");
            Console.SetCursorPosition(a, b + 8);
            Console.WriteLine("　　＼　　　　／　　　　");
            Console.SetCursorPosition(a, b + 9);
            Console.WriteLine("　　　  ────　　　　　");
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
