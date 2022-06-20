using System;

namespace ticTacToe
{
    class Program
    {
        static void Main ()
        {
            List <string> spaceList = new List<string>();
            spaceList.Add("1");
            spaceList.Add("2");
            spaceList.Add("3");
            spaceList.Add("4");
            spaceList.Add("5");
            spaceList.Add("6");
            spaceList.Add("7");
            spaceList.Add("8");
            spaceList.Add("9");
            for(int i = 1; i <= 9; i++)
            {
                int player = i;
                static void drawGrid (List<string> spaceList)
                {
                    Console.WriteLine($" {spaceList[0]} | {spaceList[1]} | {spaceList[2]} ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {spaceList[3]} | {spaceList[4]} | {spaceList[5]} ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {spaceList[6]} | {spaceList[7]} | {spaceList[8]} ");
                    
                }

                static string playerInput()
                {
                    Console.WriteLine("Enter in a number 1-9:  ");
                    string input = Console.ReadLine();
                    return input;
                }
                
                static string currentPlayer(int player)
                {
                    
                    if (player == 1 || player == 3 || player == 5 || player == 7 || player == 9)
                    {
                        string replace = "X";
                        player = player + 1;
                        return replace;
                    }
                    else
                    {
                        string replace = "O";
                        player = player + 1;
                        return replace;
                    }
                    
                }
                drawGrid(spaceList);
                string space = playerInput();
                string replace = currentPlayer(player);


            }
            
        }
    }
}