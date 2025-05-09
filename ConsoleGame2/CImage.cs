﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame2.Image;

internal class CImage
{
    public static void PetImg(int a, int b)
    {
        //17*17
        //Console.WriteLine("  □■▦");     
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(a, b);
        Console.WriteLine("                                    ");
        Console.SetCursorPosition(a, b+1);
        Console.WriteLine("           ■■              ■■  ");
        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("         ■　　■          ■　　■");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine("         ■　▦　■      ■　　▦■");
        Console.SetCursorPosition(a, b + 4);
        Console.WriteLine("         ■　▦　■■■■　　▦▦■");
        Console.SetCursorPosition(a, b + 5);
        Console.WriteLine("         ■　▦　　　▦▦　　▦　■");
        Console.SetCursorPosition(a, b + 6);
        Console.WriteLine("         ■　　　　　▦▦　　　■  ");
        Console.SetCursorPosition(a, b + 7);
        Console.WriteLine("         ■　　　　　　　　　　■  ");
        Console.SetCursorPosition(a, b + 8);
        Console.WriteLine("           ■　　■　　　■　■    ");
        Console.SetCursorPosition(a, b + 9);
        Console.WriteLine("           ■　　　 　▼　　 ■    ");
        Console.SetCursorPosition(a, b + 10);
        Console.WriteLine("             ■▦　　　　　▦■    ");
        Console.SetCursorPosition(a, b + 11);
        Console.WriteLine("         ■■■　▦　　▦　■      ");
        Console.SetCursorPosition(a, b + 12);
        Console.WriteLine(" ■■  ■▦▦　　　▦▦　■        ");
        Console.SetCursorPosition(a, b + 13);
        Console.WriteLine(" ■　■▦▦　　　　▦▦　■        ");
        Console.SetCursorPosition(a, b + 14);
        Console.WriteLine(" ■　■　　　　　　▦▦　■        ");
        Console.SetCursorPosition(a, b + 15);
        Console.WriteLine(" ■　■　　　　　　　　　■        ");
        Console.SetCursorPosition(a, b + 16);
        Console.WriteLine("   ■■　　　▦■▦▦■▦▦■      ");
        Console.SetCursorPosition(a, b + 17);
        Console.WriteLine("     ■■■■■■■■■■■■      ");
        Console.SetCursorPosition(a, b + 18);
        Console.WriteLine("                                 ");
        Console.ResetColor();
    }
    public static void FoodImg(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(a, b);
        Console.WriteLine("↑　　　　　　　　　　");
        Console.SetCursorPosition(a, b + 1);
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
        Console.ResetColor();
    }
    public static void HugImg(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(a, b);
        Console.WriteLine("↓　_────　♡　　");
        Console.SetCursorPosition(a, b + 1);
        Console.WriteLine("　│＼　  　＼　♡　");
        Console.SetCursorPosition(a, b + 2);
        Console.WriteLine("　│　＼　　  ＼　　");
        Console.SetCursorPosition(a, b + 3);
        Console.WriteLine("　＼　　　 　　＼　   ");
        Console.SetCursorPosition(a, b + 4);
        Console.WriteLine("　　＼　　　 　　＼　  ");
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
        Console.ResetColor();
    }
    public static void WashImg(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
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
        Console.ResetColor();
    }
    public static void PlayImg(int a, int b)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(a, b);
        Console.WriteLine("→　　 ────　　　");
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
        Console.ResetColor();
    }
    public static void PetImgSad(int a, int b)
    {
        //17*17
        //Console.WriteLine("  □■▦");     
        Console.ForegroundColor = ConsoleColor.Yellow;       
        Console.SetCursorPosition(a, b + 8);
        Console.WriteLine("           ■　　ㅠ　　　ㅠ　■    ");
        Console.ResetColor();
    }
    public static void PetImgGood(int a, int b)
    {
        //17*17
        //Console.WriteLine("  □■▦");     
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(a, b + 8);
        Console.WriteLine("           ■　　^　　　　^　■    ");
        Console.ResetColor();
    }
    public static void PetImgHappy(int a, int b)
    {
        //17*17
        //Console.WriteLine("  □■▦");     
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(a, b + 8);
        Console.WriteLine("           ■　　○　　　○　■    ");
        Console.ResetColor();
    }
}
