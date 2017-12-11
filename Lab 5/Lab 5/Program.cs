using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] board = new string[8][];
            for (int i = 0; i < 8; i++)

            {
                System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                board[i] = new string[8];
                for (int j = 0; j < 8; j++)
                {

                    board[i][j] = "  ";
                    if (i <= 1 || i >= 6)
                    {
                        board[i][j] = "X ";
                    }
                    System.Console.Write("| " + board[i][j]);
                }
                System.Console.WriteLine("|");
            }
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");


            System.Console.WriteLine(" ");

            int tx = 0;
            int ty = 0;
            int dx = 0;
            int dy = 0;

            while (tx <= 7 && tx >= 0 && ty <= 7 && ty >= 0 && dx <= 7 && dx >= 0 && dy <= 7 && dy >= 0)
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("Enter Target X Coordinate Between 0 and 7:");
                tx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter Target Y Coordinate Between 0 and 7:");
                ty = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter Destination X Coordinate Between 0 and 7:");
                dx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Enter Destination Y Coordinate Between 0 and 7:");
                dy = int.Parse(System.Console.ReadLine());
                System.Console.Clear();

                if (tx <= 7 && tx >= 0 && ty <= 7 && ty >= 0 && dx <= 7 && dx >= 0 && dy <= 7 && dy >= 0)
                {
                    for (int i = 0; i < 8; i++)

                    {
                        System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                        board[i] = new string[8];

                        for (int j = 0; j < 8; j++)
                        {
                            board[i][j] = "  ";
                            if (i <= 1 || i >= 6)
                            {
                                board[i][j] = "X ";
                            }
                            board[tx][ty] = "  ";
                            board[dx][dy] = "X ";
                            System.Console.Write("| " + board[i][j]);
                        }
                        System.Console.WriteLine("|");
                    }
                    System.Console.WriteLine("+---+---+---+---+---+---+---+---+");
                }
            }
            System.Console.WriteLine("You entered a value that is out of bounds.");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
