using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame2.Map;

namespace ConsoleGame2.Pet
{
    internal class CPet : CMap
    {


        public int needs;
        public int point = 0;



        public void Food()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(66, 5);
            Console.WriteLine("배고파");
            FoodImg(66,6);

        }
        public void Hug()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                       ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("쓰다듬어줘");
            HugImg(66, 6);
        }
        public void Wash()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                      ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("씻을래");
            WashImg(66, 6);
        }
        public void Play()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                        ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("놀아줘");
            PlayImg(66, 6);
        }


        public void ShowNeeds()  //펫이 요구하는 것
        {
            Random random = new Random();
            needs = random.Next(1, 5);

            switch (needs)
            {
                case 1:
                    Food();
                    break;
                case 2:
                    Hug();
                    break;
                case 3:
                    Wash();
                    break;
                case 4:
                    Play();
                    break;
            }
        }



        public void GetPoint()
        {
            point += 100;
        }

        public void LosePoint()
        {
            if (point < 100)
            {
                point = 000;
            }
            else
            {
                point -= 100;
            }
        }

        public void ShowPoint()
        {
            Console.WriteLine($"점수 : {point}점");
        }

        public void Happy()
        {
            Console.SetCursorPosition(50, 7);
            Console.WriteLine(" ♡");
            Thread.Sleep(500);
            Console.SetCursorPosition(50, 7);
            Console.Write("    ");
        }

        public void Unhappy()
        {
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("ㅠㅠ");
            Thread.Sleep(500);
            Console.SetCursorPosition(50, 7);
            Console.Write("    ");
        }


        public void InputNeeds()        //플레이어가 키 입력
        {
            Console.SetCursorPosition(2, 26);

            Console.WriteLine("방향키로 강아지가 원하는 걸 들어주세요");
            Console.WriteLine("");      // 정리필요
            ConsoleKeyInfo inputKey = Console.ReadKey();

            switch (inputKey.Key)
            {
                case ConsoleKey.UpArrow:
                    Food();
                    if (needs == 1)
                    {
                        Console.SetCursorPosition(50, 7);
                        Console.WriteLine(" ♡");
                        Thread.Sleep(500);
                        Console.SetCursorPosition(50, 7);
                        Console.Write("    ");
                        GetPoint();
                    }
                    else
                    {
                        Unhappy();
                        LosePoint();
                    }
                    break;

                case ConsoleKey.DownArrow:
                    Hug();
                    if (needs == 2)
                    {
                        Happy();
                        GetPoint();
                    }
                    else
                    {
                        Unhappy();
                        LosePoint();
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    Wash();
                    if (needs == 3)
                    {
                        Happy();
                        GetPoint();
                    }
                    else
                    {
                        Unhappy();
                        LosePoint();
                    }
                    break;

                case ConsoleKey.RightArrow:
                    Play();
                    if (needs == 4)
                    {
                        Happy();
                        GetPoint();
                    }
                    else
                    {
                        Unhappy();
                        LosePoint();
                    }
                    break;

                default:
                    Console.SetCursorPosition(50, 7);
                    Console.WriteLine("뭐여;");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(50, 7);
                    Console.Write("       ");
                    LosePoint();
                    break;
            }
        }
    }
}

