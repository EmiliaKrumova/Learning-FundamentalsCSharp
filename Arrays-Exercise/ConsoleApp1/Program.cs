using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aInt = int.Parse(Console.ReadLine());// + 35;
            int bInt = int.Parse(Console.ReadLine()); //+ 64;
            int end = int.Parse(Console.ReadLine());
            int counter = 1;

            //char a = (char)aInt;
            //char b = (char)bInt;

            for (int A = 35; A <= 55; A++)

            {
                if (counter > end)
                {
                    break;
                }
                //if (A > (char)55)
                //{
                //    A = (char)35;
                //}
                for (int B = 64; B <= 96; B++)
                {
                    //if (B > (char)96)
                    //{
                    //    B = (char)64;
                    //}

                    for (int x = 1; x <= aInt; x++)
                    {
                        for (int y = 1; y <= bInt; y++)
                        {

                            char first = (char)A;
                            char second = (char)B;

                            Console.Write($"{first}{second}{x}{y}{second}{first}|");
                            A++;
                            B++;
                            y++;
                            x++;
                            counter++;
                        }
                    }
                }
            }
        }
    }
    }

