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
            bool done = false;
            for(int i = 1; i <= 9; i++)
            {
                if(done == false)
                {   
                    if(i == 1)
                    {
                        drawGrid(spaceList);
                    }
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

                    static List<string> updateList(List<string> spaceList, string space, string replace)
                    {
                        for(int i = spaceList.Count - 1; i >=0; i--)
                        {
                            if (spaceList[i].Contains(space))
                            {
                                spaceList[i] = replace;
                            }
                        }
                        return spaceList;
                    }
                    static bool checkIfWin(List<string> spaceList)
                    {
                        if(spaceList[0] == spaceList[1] && spaceList[0] == spaceList[2])
                        {
                            return true;
                        }
                        if(spaceList[0] == spaceList[3] && spaceList[0] == spaceList[6])
                        {
                            return true;
                        }if(spaceList[4] == spaceList[1] && spaceList[0] == spaceList[8])
                        {
                            return true;
                        }if(spaceList[1] == spaceList[4] && spaceList[1] == spaceList[7])
                        {
                            return true;
                        }if(spaceList[2] == spaceList[5] && spaceList[2] == spaceList[8])
                        {
                            return true;
                        }if(spaceList[2] == spaceList[4] && spaceList[2] == spaceList[6])
                        {
                            return true;
                        }if(spaceList[3] == spaceList[4] && spaceList[3] == spaceList[5])
                        {
                            return true;
                        }if(spaceList[6] == spaceList[7] && spaceList[6] == spaceList[8])
                        {
                            return true;
                        }
                        return false;
                    }

                    string space = playerInput();
                    string replace = currentPlayer(player);
                    spaceList = updateList(spaceList, space, replace);
                    drawGrid(spaceList);
                    bool yeet = checkIfWin(spaceList);
                    if (yeet == true)
                    {
                        Console.WriteLine($"Player {replace} Wins!");
                        done = true;
                    }
                }
            }
            
        }
    }
}