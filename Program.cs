using System;
using System.Buffers.Text;
using System.Diagnostics.Metrics;

namespace Lab04TicTacToe
{
    public class Player
    {
        public string Name;
        public string Marker;
        public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;
        }
    }

    internal class Program
    {
        public static string[][] Board;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            Console.Write("Player 1's name: ");
            string player1name = Console.ReadLine();
            Player player1 = new Player(player1name, " X ");

            Console.Write("Player 2's name is : ");
            string player2name = Console.ReadLine();
            Player player2 = new Player(player2name, " O ");

            Console.WriteLine("===== {0} vs {1} =====", player1.Name, player2.Name);

            Board = new string[][]
            {
                new string[] {"1", "2", "3" },
                new string[] {"4", "5", "6" },
                new string[] {"7", "8", "9" }
            };

            Player currentPlayer = player1;

            string winner = null;
            while (winner == null)
            {
                GameBoard();
                Console.WriteLine("It is currently " + currentPlayer.Name + "'s turn.");
                string selectedSlot = Console.ReadLine();

                switch (selectedSlot)
                {
                    case "1":
                        Board[0][0] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "2":
                        Board[0][1] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "3":
                        Board[0][2] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "4":
                        Board[1][0] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "5":
                        Board[1][1] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "6":
                        Board[1][2] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "7":
                        Board[2][0] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "8":
                        Board[2][1] = String.Format("{0}", currentPlayer.Marker);
                        break;
                    case "9":
                        Board[2][2] = String.Format("{0}", currentPlayer.Marker);
                        break;
                }


                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else if (currentPlayer == player2)
                {
                    currentPlayer = player1;
                }
            }
        }
        static void GameBoard()
        {
            Console.WriteLine(" {0}  {1}  {2} ", Board[0][0], Board[0][1], Board[0][2]);
            Console.WriteLine(" {0}  {1}  {2} ", Board[1][0], Board[1][1], Board[1][2]);
            Console.WriteLine(" {0}  {1}  {2} ", Board[2][0], Board[2][1], Board[2][2]);

        }
    }
}









