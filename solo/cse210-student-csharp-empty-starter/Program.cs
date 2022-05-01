using System;
using System.Collections.Generic;
namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X or O");
            string player = Console.ReadLine();
            string computer = "nothing";
//I know there is a more efficient method, but in C# as long as I modify something, everything stops working
            List<string> Game = new List<string>();
            Game.Add("1");
            Game.Add("2");
            Game.Add("3");
            Game.Add("4");
            Game.Add("5");
            Game.Add("6");
            Game.Add("7");
            Game.Add("8");
            Game.Add("9");


            if(player == "X")
            {
                computer = "O";
            }
            else
            {
                computer = "X";
            }

            bool finish = false;
            Display(Game);

            while(finish==false)
            {
                int counter = 0;
                Console.WriteLine($"{player} turn, choose a number: ");
                int selector = int.Parse(Console.ReadLine())-1;
                Game[selector] = player;
                counter++;
                Display(Game);
                finish = Winning(Game);
                if(finish==true)
                {
                    Console.WriteLine($"{player} wins");
                }

                //computer's turn
                if(finish==false)
                {
                    Console.WriteLine($"{computer} turn ");
                    Random randomGenerator = new Random();
                    int number = randomGenerator.Next(1, 9);
                    if(Game[number] == player)
                        {
                            number = randomGenerator.Next(1, 9);
                        }
                    Game[number] = computer;
                    counter++;
                    Display(Game);
                    finish = Winning(Game);
                    if(finish==true)
                {
                    Console.WriteLine($"{computer} wins");
                }
                }


                //draw
                if(counter==9)
                {
                    finish=true;
                    Console.WriteLine("Draw");
                }
            }

            void Display(List<string> Game )
            {
                Console.WriteLine($"{Game[0]}|{Game[1]}|{Game[2]}");
                Console.WriteLine($"-+-+-");
                Console.WriteLine($"{Game[3]}|{Game[4]}|{Game[5]}");
                Console.WriteLine($"-+-+-");
                Console.WriteLine($"{Game[6]}|{Game[7]}|{Game[8]}");
            }
            
            bool Winning(List<string> Game)
            {   
                bool finish = false;
                if((Game[0] == Game[1]) & (Game[0] == Game[2]) & (Game[1] == Game[2]))
                {
                    finish = true;
                }
                else if((Game[3] == Game[4]) & (Game[3] == Game[5]) & (Game[4] == Game[5]))
                {
                    finish = true;
                }
                else if((Game[6] == Game[7]) & (Game[6] == Game[8]) & (Game[7] == Game[8]))
                {
                    finish = true;
                }
                else if((Game[0] == Game[3]) & (Game[0] == Game[6]) & (Game[3] == Game[6]))
                {
                    finish = true;
                }
                else if((Game[1] == Game[4]) & (Game[1] == Game[7]) & (Game[4] == Game[7]))
                {
                    finish = true;
                }
                else if((Game[2] == Game[5]) & (Game[2] == Game[8]) & (Game[5] == Game[8]))
                {
                    finish = true;
                }
                else if((Game[0] == Game[4]) & (Game[0] == Game[8]) & (Game[4] == Game[8]))
                {
                    finish = true;
                }
                else if((Game[2] == Game[4]) & (Game[2] == Game[7]) & (Game[4] == Game[6]))
                {
                    finish = true;
                }
                return finish;
            }
        }
    }
}
