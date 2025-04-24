using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame2.Map;
using ConsoleGame2.Image;
using ConsoleGame2.Player;
using ConsoleGame2.Setting;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using ConsoleGame2.PlayingGame;

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
            CImage.FoodImg(66,6);

        }
        public void Hug()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                       ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("쓰다듬어줘");
            CImage.HugImg(66, 6);
        }
        public void Wash()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                      ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("씻을래");
            CImage.WashImg(66, 6);
        }
        public void Play()
        {
            Console.SetCursorPosition(66, 5);
            Console.Write("                        ");
            Console.SetCursorPosition(66, 5);

            Console.WriteLine("놀아줘");
            CImage.PlayImg(66, 6);
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

        public void Happy()
        {
            Console.SetCursorPosition(50, 7);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("∠( ♡ )");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.SetCursorPosition(50, 7);
            Console.Write("          ");
        }

        public void Unhappy()
        {
            Console.SetCursorPosition(50, 7);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("∠( ㅠㅠ )");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.SetCursorPosition(50, 7);
            Console.Write("           ");
        }
        public void GetPoint()
        {
            point += 100;
        }

        public void LosePoint()
        {
            if (point < 100)
            {
                point = 0;
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


        public void InputNeeds()        //플레이어가 키 입력
        {
            Console.SetCursorPosition(2, 26);

            Console.WriteLine("방향키로 강아지가 원하는 걸 들어주세요");
            Console.WriteLine("");


            ConsoleKeyInfo inputKey = Console.ReadKey();            
                switch (inputKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        //Food();
                        if (needs == 1)
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

                    case ConsoleKey.DownArrow:
                        //Hug();
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
                        //Wash();
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
                        //Play();
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
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("∠( 엥; )");
                        Console.ResetColor();
                        Thread.Sleep(500);
                        Console.SetCursorPosition(50, 7);
                        Console.Write("          ");
                        LosePoint();
                        break;
                }
            }
               
        
        public void ShowResult()
        {
            if (point <= 500)
            {
                Console.SetCursorPosition(50, 16);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("강아지를 더 아껴주세요..");
                Console.ResetColor();
                CImage.PetImg(10, 10);
                CImage.PetImgSad(10,10);
            }
            else if (point > 500 && point <= 1500)
            {
                Console.SetCursorPosition(50, 16);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("강아지가 즐거워하네요!");
                Console.ResetColor();
                CImage.PetImg(10, 10);
                CImage.PetImgGood(10, 10);
            }
            else if (point > 1500)
            {
                Console.SetCursorPosition(50, 16);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("강아지가 정말 행복해하고 있어요!");
                Console.ResetColor();
                CImage.PetImg(10, 10);
                CImage.PetImgHappy(10, 10);
                Thread.Sleep(500);
                CImage.PetImg(10, 11);
                CImage.PetImgHappy(10, 11);
                Thread.Sleep(500);
                CImage.PetImg(10, 10);
                CImage.PetImgHappy(10, 10);
            }

        }



    }
}

