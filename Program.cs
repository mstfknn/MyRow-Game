using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace C_Sharp_Console_Kayan_Yazı
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "MyRow";

            Console.Clear();
            bool a = true;
            int count = 0;

            // we cant upload music file so we add comment line
            //SoundPlayer player = new SoundPlayer();
            //string path = "1.wav"; // file place
            //player.SoundLocation = path;
            //player.Play(); //play it

            string yazi = "................................................................................";
            string kayan_yazi = Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "     " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "......................................................................";
            string kayan_yazi1 = Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "     " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "......................................................................";
            string kayan_yazi2 = Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "     " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "  " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + " " + Convert.ToChar(2) + "   " + Convert.ToChar(2) + "............................................................";
            string kayan_yazi3 = Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "............................................................";
            string kayan_yazi4 = Convert.ToChar(2) + "   " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + " " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + " " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "............................................................";
            string kayan_yazi5 = "        " + Convert.ToChar(2) + "              " + "............................................................";
            string kayan_yazi6 = "      " + Convert.ToChar(2) + "" + Convert.ToChar(2) + "" + Convert.ToChar(2) + "              " + "............................................................";
            while (a)
            {
                Thread.Sleep(100);

                Console.SetCursorPosition(0, 0);
                yazi = yazi.Substring(1) + yazi.Substring(0, 1);
                kayan_yazi = kayan_yazi.Substring(1) + kayan_yazi.Substring(0, 1);
                kayan_yazi1 = kayan_yazi1.Substring(1) + kayan_yazi1.Substring(0, 1);
                kayan_yazi2 = kayan_yazi2.Substring(1) + kayan_yazi2.Substring(0, 1);
                kayan_yazi3 = kayan_yazi3.Substring(1) + kayan_yazi3.Substring(0, 1);
                kayan_yazi4 = kayan_yazi4.Substring(1) + kayan_yazi4.Substring(0, 1);
                kayan_yazi5 = kayan_yazi5.Substring(1) + kayan_yazi5.Substring(0, 1);
                kayan_yazi6 = kayan_yazi6.Substring(1) + kayan_yazi6.Substring(0, 1);
                Console.WriteLine(yazi);

                Console.SetCursorPosition(0, 1);

                Console.WriteLine(kayan_yazi.Substring(6) + kayan_yazi.Substring(5, 1));

                Console.SetCursorPosition(0, 2);

                Console.WriteLine(kayan_yazi1.Substring(6) + kayan_yazi1.Substring(10, 1));

                Console.SetCursorPosition(0, 3);

                Console.WriteLine(kayan_yazi2.Substring(6) + kayan_yazi2.Substring(15, 1));

                Console.SetCursorPosition(0, 4);

                Console.WriteLine(kayan_yazi3.Substring(6) + kayan_yazi3.Substring(21, 1));

                Console.SetCursorPosition(0, 5);

                Console.WriteLine(kayan_yazi4.Substring(6) + kayan_yazi4.Substring(29, 1));

                Console.SetCursorPosition(0, 6);

                Console.WriteLine(kayan_yazi5.Substring(6) + kayan_yazi5.Substring(0, 1));

                Console.SetCursorPosition(0, 7);

                Console.WriteLine(kayan_yazi6.Substring(6) + kayan_yazi6.Substring(32, 1));
                Console.WriteLine(yazi);


                count++;

                if (count == 130) 
                a = false;
                
                else 

                a= true;

            }
            //Console.WriteLine("Please press enter to continue...");
            
            //    ConsoleKeyInfo enter = Console.ReadKey();

            //    if (enter.Key == ConsoleKey.Enter)
            //    {     
                


                    Console.SetCursorPosition(0, 11);

                Console.WriteLine("Please chose the options:");
                Console.WriteLine("1-Start The Game");
                Console.WriteLine("2-About The Game");
                Console.WriteLine("3-Exit");

                int options;
                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        {

                            
                          Console.Clear();

                          ///Coloured Screen
                          Console.BackgroundColor = ConsoleColor.DarkBlue;
                          Console.ForegroundColor = ConsoleColor.White;
                          Console.Clear();
                          Console.WriteLine("CHOOSE YOUR COLOUR(A,S,D,Z)");
                          Console.WriteLine("A-Background:White,Foreground:Red");
                          Console.WriteLine("S-Background:White,Foreground:DarkGray");
                          Console.WriteLine("D-Background:DarkGree,Foreground:White");
                          Console.WriteLine("Z-Background:White,Foreground:Black");
                          Console.WriteLine("X-Background:Cyan,Foreground:DarkBlue");
                          Console.WriteLine("C-Background:Black,Foreground:DarkRed");

                          ConsoleKeyInfo colour = Console.ReadKey();
                          if (colour.Key == ConsoleKey.A)
                          {
                              Console.BackgroundColor = ConsoleColor.White;
                              Console.ForegroundColor = ConsoleColor.Red;
                          }
                          if (colour.Key == ConsoleKey.S)
                          {
                              Console.BackgroundColor = ConsoleColor.White;
                              Console.ForegroundColor = ConsoleColor.DarkGray;
                          }
                          if (colour.Key == ConsoleKey.D)
                          {
                              Console.BackgroundColor = ConsoleColor.DarkGreen;
                              Console.ForegroundColor = ConsoleColor.White;
                          }
                          if (colour.Key == ConsoleKey.Z)
                          {
                              Console.BackgroundColor = ConsoleColor.White;
                              Console.ForegroundColor = ConsoleColor.Black;
                          }
                          if (colour.Key == ConsoleKey.X)
                          {
                              Console.BackgroundColor = ConsoleColor.Cyan;
                              Console.ForegroundColor = ConsoleColor.DarkBlue;
                          }
                          if (colour.Key == ConsoleKey.C)
                          {
                              Console.BackgroundColor = ConsoleColor.Black;
                              Console.ForegroundColor = ConsoleColor.DarkRed;
                          }

                          Console.Clear();

                          // dil seçeneği ekle switch case
                          ///Board
                          int usersscore = 0;
                          int pcscore = 0;
                          Console.WriteLine("    1  2  3  4  5  6  7  8");
                          Console.WriteLine("   ------------------------              Player:" + usersscore);
                          Console.WriteLine(" 1|                        |");
                          Console.WriteLine(" 2|                        |           Computer:" + pcscore);
                          Console.WriteLine(" 3|                        |");
                          Console.WriteLine(" 4|                        |");
                          Console.WriteLine(" 5|                        |");
                          Console.WriteLine(" 6|                        |");
                          Console.WriteLine(" 7|                        |");
                          Console.WriteLine(" 8|                        |");
                          Console.WriteLine("   ------------------------");

                          Random rnd = new Random();

                          int[,] arr2d = new int[8, 8];
                          int x = 3;
                          int y = 2;
                          ///Randomly Placed Numbers
                          for (int i = 0; i < arr2d.GetLength(0); i++)
                          {
                              for (int j = 0; j < arr2d.GetLength(1); j++)
                              {

                                  do
                                      arr2d[i, j] = rnd.Next(-9, 10);
                                  while (arr2d[i, j] == 0);
                                  ///Blank of th numbers
                                  if (arr2d[i, j] > 0)
                                  {

                                      Console.SetCursorPosition(x, y);
                                      Console.Write(" " + arr2d[i, j]);
                                      x = x + 1;
                                  }
                                  else
                                  {

                                      Console.SetCursorPosition(x, y);

                                      Console.Write(arr2d[i, j]);
                                      x = x + 1;
                                  }
                                  x = x + 2;
                              }
                              x = 3;
                              y = y + 1;

                              Console.WriteLine();

                          }
                          ///Randomly Placed To First Coordinates
                          int satir, sutun;
                          Random rnd2 = new Random();
                          satir = rnd2.Next(0, 8);
                          sutun = rnd2.Next(0, 8);
                          ///In order to prevent lapses
                          if (arr2d[satir, sutun] < 0)
                          {
                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                              Console.Write(" " + (char)2);
                          }
                          else
                          {
                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                              Console.Write((char)2);
                          }

                          arr2d[satir, sutun] = -99;
                          int finishcount = 0, finishcount2 = 0;///These variables in order to check for end of the game
                          bool wincase = true;
                          while (wincase)
                          {

                              bool flag = true;
                              ///Player Moves 
                              while (flag)
                              {
                                  finishcount = 0;
                                  finishcount2 = 0;
                                  ConsoleKeyInfo ctrl = Console.ReadKey(true);
                                  flag = false;
                                  switch (satir)
                                  {
                                      case 0:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {

                                                      if (arr2d[0, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 0] = -99;
                                                          satir = 0;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }


                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[0, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 1] = -99;
                                                          satir = 0;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[0, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 2] = -99;
                                                          satir = 0;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[0, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 3] = -99;
                                                          satir = 0;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[0, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 4] = -99;
                                                          satir = 0;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[0, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 5] = -99;
                                                          satir = 0;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[0, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 6] = -99;
                                                          satir = 0;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[0, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 2);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[0, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[0, 7] = -99;
                                                          satir = 0;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      ///To find count of -99's
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }

                                          }
                                          break;

                                      case 1:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[1, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 0] = -99;
                                                          satir = 1;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[1, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 1] = -99;
                                                          satir = 1;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[1, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 2] = -99;
                                                          satir = 1;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[1, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 3] = -99;
                                                          satir = 1;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[1, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 4] = -99;
                                                          satir = 1;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[1, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 5] = -99;
                                                          satir = 1;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore); flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[1, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 6] = -99;
                                                          satir = 1;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[1, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 3);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[1, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[1, 7] = -99;
                                                          satir = 1;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;
                                      case 2:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[2, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 0] = -99;
                                                          satir = 2;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[2, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 1] = -99;
                                                          satir = 2;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[2, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 2] = -99;
                                                          satir = 2;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[2, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 3] = -99;
                                                          satir = 2;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[2, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 4] = -99;
                                                          satir = 2;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;

                                                  } for (int i = 0; i < arr2d.GetLength(0); i++)
                                                  {
                                                      if (arr2d[i, 4] == -99)
                                                          finishcount++;
                                                  }
                                                  if (finishcount == arr2d.GetLength(0))
                                                      wincase = false;
                                                  if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[2, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 5] = -99;
                                                          satir = 2;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[2, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 6] = -99;
                                                          satir = 2;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[2, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 4);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[2, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[2, 7] = -99;
                                                          satir = 2;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;
                                      case 3:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[3, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 0] = -99;
                                                          satir = 3;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[3, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 1] = -99;
                                                          satir = 3;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[3, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 2] = -99;
                                                          satir = 3;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[3, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 3] = -99;
                                                          satir = 3;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true; for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[3, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 4] = -99;
                                                          satir = 3;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[3, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 5] = -99;
                                                          satir = 3;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);

                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[3, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 6] = -99;
                                                          satir = 3;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[3, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 5);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[3, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[3, 7] = -99;
                                                          satir = 3;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true; for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;
                                      case 4:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[4, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 0] = -99;
                                                          satir = 4;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }

                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[4, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 1] = -99;
                                                          satir = 4;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[4, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 2] = -99;
                                                          satir = 4;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[4, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 3] = -99;
                                                          satir = 4;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[4, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 4] = -99;
                                                          satir = 4;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[4, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 5] = -99;
                                                          satir = 4;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[4, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[4, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 6] = -99;
                                                          satir = 4;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[4, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 6);
                                                          Console.Write(" " + (char)2);
                                                          usersscore
                                                              = usersscore + arr2d[4, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[4, 7] = -99;
                                                          satir = 4;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;

                                      case 5:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[5, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 0] = -99;
                                                          satir = 5;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[5, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 1] = -99;
                                                          satir = 5;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[5, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 2] = -99;
                                                          satir = 5;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);

                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[5, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 3] = -99;
                                                          satir = 5;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);

                                                          Console.Write(usersscore); flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[5, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 4] = -99;
                                                          satir = 5;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[5, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 5] = -99;
                                                          satir = 5;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[5, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 6] = -99;
                                                          satir = 5;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[5, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 7);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[5, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[5, 7] = -99;
                                                          satir = 5;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;
                                      case 6:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[6, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 0] = -99;
                                                          satir = 6;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[6, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 1] = -99;
                                                          satir = 6;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[6, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 2] = -99;
                                                          satir = 6;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  } if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[6, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 3] = -99;
                                                          satir = 6;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[6, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 4] = -99;
                                                          satir = 6;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[6, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 5] = -99;
                                                          satir = 6;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[6, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 6] = -99;
                                                          satir = 6;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[6, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 8);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[6, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[6, 7] = -99;
                                                          satir = 6;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;

                                              }
                                          }
                                          break;
                                      case 7:
                                          {

                                              {
                                                  if (ctrl.Key == ConsoleKey.NumPad1)
                                                  {
                                                      if (arr2d[7, 0] != -99)
                                                      {
                                                          Console.SetCursorPosition(3, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 0];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 0] = -99;
                                                          satir = 7;
                                                          sutun = 0;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 0] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  } if (ctrl.Key == ConsoleKey.NumPad2)
                                                  {
                                                      if (arr2d[7, 1] != -99)
                                                      {
                                                          Console.SetCursorPosition(6, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 1];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 1] = -99;
                                                          satir = 7;
                                                          sutun = 1;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 1] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }

                                                  if (ctrl.Key == ConsoleKey.NumPad3)
                                                  {
                                                      if (arr2d[7, 2] != -99)
                                                      {
                                                          Console.SetCursorPosition(9, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 2];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 2] = -99;
                                                          satir = 7;
                                                          sutun = 2;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 2] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad4)
                                                  {
                                                      if (arr2d[7, 3] != -99)
                                                      {
                                                          Console.SetCursorPosition(12, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 3];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 3] = -99;
                                                          satir = 7;
                                                          sutun = 3;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 3] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad5)
                                                  {
                                                      if (arr2d[7, 4] != -99)
                                                      {
                                                          Console.SetCursorPosition(15, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 4];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 4] = -99;
                                                          satir = 7;
                                                          sutun = 4;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);

                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 4] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad6)
                                                  {
                                                      if (arr2d[7, 5] != -99)
                                                      {
                                                          Console.SetCursorPosition(18, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 5];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 5] = -99;
                                                          satir = 7;
                                                          sutun = 5;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 5] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;
                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad7)
                                                  {
                                                      if (arr2d[7, 6] != -99)
                                                      {
                                                          Console.SetCursorPosition(21, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 6];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 6] = -99;

                                                          satir = 7;
                                                          sutun = 6;
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write("   ");
                                                          Console.SetCursorPosition(48, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 6] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))
                                                          wincase = false;

                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad8)
                                                  {
                                                      if (arr2d[7, 7] != -99)
                                                      {
                                                          Console.SetCursorPosition(24, 9);
                                                          Console.Write(" " + (char)2);
                                                          usersscore = usersscore + arr2d[7, 7];

                                                          if (arr2d[satir, sutun] < 0)
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          else
                                                          {
                                                              Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                              Console.Write(" ");
                                                          }
                                                          Console.Write(" ");
                                                          arr2d[7, 7] = -99;
                                                          satir = 7;
                                                          sutun = 7;
                                                          Console.SetCursorPosition(46, 1);
                                                          Console.Write(usersscore);
                                                          flag = false;
                                                      }

                                                      else
                                                          flag = true;
                                                      for (int i = 0; i < arr2d.GetLength(0); i++)
                                                      {
                                                          if (arr2d[i, 7] == -99)
                                                              finishcount++;
                                                      }
                                                      if (finishcount == arr2d.GetLength(0))

                                                          wincase = false;


                                                  }
                                                  if (ctrl.Key == ConsoleKey.NumPad9)
                                                      flag = true;


                                              }

                                              break;
                                          }
                                  }
                              }


                              ///Beginnin of the computer moves 
                              int result = 0;
                              int temp = 0;///New line which the computer found maximum result and went  
                              switch (sutun)
                              {
                                  case (0):
                                      {

                                          int maximum = 0;
                                          ///In order to find suitable line for its
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 0] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          }
                                          if (arr2d[temp, 0] != -99)
                                          {
                                              Console.SetCursorPosition(3, 2 + temp);
                                              Console.Write(" " + (char)2);
                                              pcscore = pcscore + arr2d[temp, 0];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 0] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);

                                          }///These codes for checked end of the game for columns
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;

                                  case (1):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 1] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          }
                                          if (arr2d[temp, 1] != -99)
                                          {
                                              Console.SetCursorPosition(6, temp + 2);
                                              Console.Write(" " + (char)2);
                                              pcscore = pcscore + arr2d[temp, 1];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 1] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;





                                  case (2):
                                      {
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              int maximum = 0;
                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 2] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          }
                                          if (arr2d[temp, 2] != -99)
                                          {
                                              Console.SetCursorPosition(9, temp + 2);
                                              Console.Write(" " + (char)2);
                                              pcscore = pcscore + arr2d[temp, 2];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 2] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                                  case (3):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 3] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          } if (arr2d[temp, 3] != -99)
                                          {
                                              Console.SetCursorPosition(12, temp + 2);
                                             
                                                  Console.Write(" " + (char)2);
                                             
                                              pcscore = pcscore + arr2d[temp, 3];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 3] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                                  case (4):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 4] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          } if (arr2d[temp, 4] != -99)
                                          {
                                              Console.SetCursorPosition(15, temp + 2);
                                              
                                                  Console.Write(" " + (char)2);
                                              
                                              pcscore = pcscore + arr2d[temp, 4];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 4] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                                  case (5):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 5] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          } if (arr2d[temp, 5] != -99)
                                          {
                                              Console.SetCursorPosition(18, temp + 2);
                                             
                                                  Console.Write(" " + (char)2);
                                              
                                              pcscore = pcscore + arr2d[temp, 5];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 5] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                                  case (6):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 6] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          } if (arr2d[temp, 6] != -99)
                                          {
                                              Console.SetCursorPosition(21, 2 + temp);
                                             
                                                  Console.Write(" " + (char)2);
                                            
                                              pcscore = pcscore + arr2d[temp, 6];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 6] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                                  case (7):
                                      {
                                          int maximum = 0;
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {

                                              for (int j = 1; j < arr2d.GetLength(1) - 1; j++)
                                              {
                                                  result = arr2d[i, 7] - arr2d[i, j];
                                                  if (result > maximum)
                                                  {
                                                      maximum = result;
                                                      temp = i;
                                                  }
                                              }

                                          } if (arr2d[temp, 7] != -99)
                                          {
                                              Console.SetCursorPosition(24, temp + 2);
                                              
                                                  Console.Write(" " + (char)2);
                                    
                                              pcscore = pcscore + arr2d[temp, 7];

                                              if (arr2d[satir, sutun] < 0)
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 3, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              else
                                              {
                                                  Console.SetCursorPosition(sutun * 3 + 4, satir + 2);
                                                  Console.Write(" ");
                                              }
                                              arr2d[temp, 7] = -99;
                                              Console.Write(" ");
                                              satir = temp;
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write("   ");
                                              Console.SetCursorPosition(48, 3);
                                              Console.Write(pcscore);
                                          }
                                          for (int i = 0; i < arr2d.GetLength(0); i++)
                                          {
                                              if (arr2d[temp, i] == -99)
                                                  finishcount2++;
                                          }
                                          if (finishcount2 == arr2d.GetLength(0))
                                              wincase = false;
                                      }
                                      break;
                              }

                          }
                          Console.Clear();
                          ///Checking winner
                          if (pcscore > usersscore)
                          {
                              Console.SetCursorPosition(33, 9);
                              Console.WriteLine("COMPUTER WON with"+" "+pcscore+" Point" );
                              Console.SetCursorPosition(33, 10);
                              Console.WriteLine("YOU LOST with" +" "+usersscore+" Point");

                          }
                          if (pcscore < usersscore)
                          {
                              Console.SetCursorPosition(33, 9);
                              Console.WriteLine("YOU WON with" + " " + usersscore + " Point");
                              Console.SetCursorPosition(33, 10);
                              Console.WriteLine("COMPUTER LOST with" + " " + pcscore + " Point");
                          }
                          if (pcscore == usersscore)
                          {
                              Console.SetCursorPosition(33, 9);
                              Console.WriteLine("Win-Win");///If the scores are equal,write "win" for both of them
                          }

                          Console.ReadLine();




































 
                            break;
                        }


                        break;
                        {
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Game Rules:");
                            Console.WriteLine("1-The game is played on a board which has 8*8 fields.");
                            Console.WriteLine("2-The player has the first move he/she can only move the cursor horizontally");
                            Console.WriteLine("and gain the number add the cursors position. In the computers turn, it can");
                            Console.WriteLine("only move vertically and again collects the number at cursors position after ");
                            Console.WriteLine("collecting number cursor square becomes empty.");
                            Console.WriteLine("3-Player or computer has to move for their turns they can not pass.");
                            Console.WriteLine("4-During the player or computers turn, if there is a no possible move , which");
                            Console.WriteLine("means if there  is no number in the row or column, the game is the over and");
                            Console.WriteLine("the player that has the highest score wins.");
                            Console.WriteLine("");
                            Console.WriteLine("Duration: 5 Weeks  ");
                            Console.WriteLine("");
                            Console.WriteLine("Developers:");
                            Console.WriteLine("Gamze Aycan");
                            Console.WriteLine("Sercan Oktay");
                            Console.WriteLine("Mustafa Kaan Demirhan");

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                }
        
                    
                 




                

                Console.ReadLine();
            }




        
        
        }
    }
