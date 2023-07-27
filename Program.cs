using Internal;

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
            Console.WriteLine(“Welcome to Tic Tac Toe!“);
            Console.Write("Player 1's name is : ");
            string player1name = Console.ReadLine();
            Player player1 = new Player(player1name, “X”);
            Console.Write("Player 2's name is : ");
            string player2name = Console.ReadLine();
            Player player2 = new Player(player2name, “O”);
            Board = new string[][] {
                new string[]{"1","2","3"},
                new string[]{"4","5","6"},
                new string[]{"7","8","9"}
            };
            Console.WriteLine(“Here’s the board”);
            GameBoard();
            Player currentPlayer = player1;
            string winner = null;
            while (winner == null)
            {
                Console.Clear();
                Console.WriteLine("It is currently " + currentPlayer.Name + "‘s turn.");
                GameBoard();
                Console.WriteLine(“Choose a slot currently”);
                string selectedSlot = Console.ReadLine();
                bool isValid = SelectionIsValid(selectedSlot);
                if (isValid)
                {
                    int[] indexes = SelectionToIndexes(selectedSlot);
                    int row = indexes[0];
                    int column = indexes[1];
                    Board[row][column] = currentPlayer.Marker;
                }
                else
                {
                    continue;
                }
                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else if (currentPlayer == player2)
                {
                    currentPlayer = player1;
                }

                if (CheckForWinner())
                {
                    winner = currentPlayer.Name;
                }
                else if (!Draw())
                {
                    winner = "Draw";
                }
            }
        }
        static void GameBoard()
        {
            Console.WriteLine(“|{ 0}||{ 1}||{ 2}|“, Board[0][0], Board[0][1], Board[0][2]);
            Console.WriteLine(“|{ 0}||{ 1}||{ 2}|“, Board[1][0], Board[1][1], Board[1][2]);
            Console.WriteLine(“|{ 0}||{ 1}||{ 2}|“, Board[2][0], Board[2][1], Board[2][2]);
        }
        static int[] SelectionToIndexes(string selectedSlot)
        {
            int[] indexes = new int[2];
            switch (selectedSlot)
            {
                case “1”:
                    indexes[0] = 0;
                    indexes[1] = 0;
                    break;
                case “2":
                    indexes[0] = 0;
                    indexes[1] = 1;
                    break;
                case “3”:
                    indexes[0] = 0;
                    indexes[1] = 2;
                    break;
                case “4":
                    indexes[0] = 1;
                    indexes[1] = 0;
                    break;
                case “5”:
                    indexes[0] = 1;
                    indexes[1] = 1;
                    break;
                case “6":
                    indexes[0] = 1;
                    indexes[1] = 2;
                    break;
                case “7”:
                    indexes[0] = 2;
                    indexes[1] = 0;
                    break;
                case “8":
                    indexes[0] = 2;
                    indexes[1] = 1;
                    break;
                case “9”:
                    indexes[0] = 2;
                    indexes[1] = 2;
                    break;
            }
            return indexes;
        }
        static bool SelectionIsValid(string selectedSlot)
        {
            bool isValid = true;
            int[] indexes = SelectionToIndexes(selectedSlot);
            int row = indexes[0];
            int column = indexes[1];
            string slotValue = Board[row][column];
            if (slotValue == “X” || slotValue == “O”)
            {
                isValid = false;
            }
            if (isValid == false)
            {
                Console.WriteLine(“Selection is invalid”);
            }
            return isValid;
        }

        // Check for a winner after the move
        winningLine = CheckWinner();
        static bool Draw()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (Board[row][col] != "X" && Board[row][col] != "O")
                    {
                        return true;
                    }
                }
            }
            return false;

            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else if (currentPlayer == player2)
            {
                currentPlayer = player1;
            }
            if (CheckWinner == "Draw")
            {
                Console.WriteLine("It's a Draw, You Both Suck")
            }
        }

        // Display the winner
        Console.WriteLine("The winner is " + winner);

// Mark the winning line on the board
MarkWinningLine(winningLine);
    }

    static void MarkWinningLine(string[] linePositions)
    {
        if (linePositions != null)
        {
            int rowStart = int.Parse(linePositions[0]);
            int colStart = int.Parse(linePositions[1]);
            int rowEnd = int.Parse(linePositions[2]);
            int colEnd = int.Parse(linePositions[3]);

            for (int row = rowStart; row <= rowEnd; row++)
            {
                for (int col = colStart; col <= colEnd; col++)
                {
                    Board[row][col] = "W"; // Mark the winning line with "W"
                }
            }

            // Display the board with the winning line
            GameBoard();
        }
    }

    static string[] CheckWinner()
    {
        // ... Rest of the code remains the same

        if (Board[row][0] == Board[row][1] && Board[row][1] == Board[row][2])
            return new string[] { row.ToString(), "0", row.ToString(), "2" };

        // ... Rest of the code remains the same

        if (Board[0][0] == Board[1][1] && Board[1][1] == Board[2][2])
            return new string[] { "0", "0", "2", "2" };

        if (Board[0][2] == Board[1][1] && Board[1][1] == Board[2][0])
            return new string[] { "0", "2", "2", "0" };

        return null; // No winner
    }
}
    }
}
