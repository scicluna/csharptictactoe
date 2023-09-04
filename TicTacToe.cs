using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    public class TicTacToe
    {
        public char?[] board = new char?[9];
        public bool xTurn = true;

        public void playMove(int index)
        {
            if (!board[index].HasValue)
            {
                board[index] = xTurn ? 'X' : 'O';
            }
        }

        public bool checkForWin()
        {
            char currentPlayer = xTurn ? 'X' : 'O';  // It should be 'O' for the other player, not 'Y'

            // Rows
            if (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) return true;
            if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) return true;
            if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) return true;

            // Columns
            if (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) return true;
            if (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) return true;
            if (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) return true;

            // Diagonals
            if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) return true;
            if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer) return true;

            return false;
        }

        public void switchPlayer()
        {
            xTurn = !xTurn;
        }

        public void Reset()
        {
            board = new char?[9];
            xTurn = true;
        }

    }
}
