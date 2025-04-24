using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame2.Setting
{
    internal class CSetting
    {
        public static void WindowSet()
        {
            Console.SetWindowSize(100, 40);     //윈도우창 사이즈 100*40
            Console.CursorVisible = false;        //커서 안보이게 설정
        }
        public static async Task GameTimer1()      //타이머 1 : 제한시간이 줄어드는 것을 숫자로 표현
        {
            Console.Write("게임 시작!");
            Console.Write("            ");
            for (int k = 30; k > 0; k--)
            {
                Console.SetCursorPosition(1, 1);
                Console.Write($"제한 시간 : {k}");
                await Task.Delay(1006);
                Console.SetCursorPosition(10, 1);
                Console.Write("        ");
            }
            Console.SetCursorPosition(1, 1);
            Console.Write($"제한 시간 종료");
        }
        public static async Task GameTimer2()      //타이머 2 : 제한시간을 프로그레스바로 표현
        {
            Console.SetCursorPosition(1, 2);
            Console.Write("                                                           ");
            Console.SetCursorPosition(1, 2);
            Console.Write($"[\t\t\t\t\t\t\t      ]");
            for (int i = 1; i <= 30; i++) //30초동안 게이지 채우기
            {
                Console.SetCursorPosition(i * 2, 2);
                Console.Write("■");
                await Task.Delay(993);
            }
        }
    }
}
