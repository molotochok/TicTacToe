using System;
using System.Windows.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Represents a board of the game
    /// </summary>
    class Board
    {
        public readonly Int32 WIDTH = 3;
        public readonly Int32 HEIGHT = 3;

        private ElementType[,] _boardElements;
        public ElementType this[int x, int y] {
            get  => _boardElements[x, y];
            set 
            {
                _boardElements[x, y] = value;
            }
        }

        /// <summary>
        /// Stores indexes of the elements in _boardElements that caused winning 
        /// </summary>
        public Int32[,] WinningIndexes { get; private set; }

        public event EventHandler BoardChanged;

        public Board()
        {
            _boardElements = new ElementType[WIDTH, HEIGHT];
            WinningIndexes = new Int32[WIDTH, 2];
        }

        /// <summary>
        /// Updates UI board when _boardElements is changed
        /// </summary>
        public void UpdateBoardUI()
        {
            BoardChanged?.Invoke(this, null);
        }

        /// <summary>
        /// Check if board has win condition
        /// </summary>
        /// <param name="elementType">X or O</param>
        /// <returns>True if win, false if not</returns>
        public bool IsWin(ElementType elementType)
        {
            if ((this[0, 0] == elementType && this[0, 1] == elementType && this[0, 2] == elementType)){
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 0;
                WinningIndexes[1, 0] = 0; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 0; WinningIndexes[2, 1] = 2;
                return true;
            }

            if((this[0, 0] == elementType && this[1, 0] == elementType && this[2, 0] == elementType))
            {
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 0;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 0;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 0;
                return true;
            }
            if ((this[0, 0] == elementType && this[1, 1] == elementType && this[2, 2] == elementType))
            {
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 0;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 2;
                return true;
            }
            if ((this[0, 1] == elementType && this[1, 1] == elementType && this[2, 1] == elementType))
            {
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 1;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 1;
                return true;
            }
            if ((this[0, 2] == elementType && this[1, 2] == elementType && this[2, 2] == elementType))
            {
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 2;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 2;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 2;
                return true;
            }
            if ((this[0, 2] == elementType && this[1, 1] == elementType && this[2, 0] == elementType))
            {
                WinningIndexes[0, 0] = 0; WinningIndexes[0, 1] = 2;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 0;
                return true;
            }
            if ((this[1, 0] == elementType && this[1, 1] == elementType && this[1, 2] == elementType))
            {
                WinningIndexes[0, 0] = 1; WinningIndexes[0, 1] = 0;
                WinningIndexes[1, 0] = 1; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 1; WinningIndexes[2, 1] = 2;
                return true;
            }
            if ((this[2, 0] == elementType && this[2, 1] == elementType && this[2, 2] == elementType))
            {
                WinningIndexes[0, 0] = 2; WinningIndexes[0, 1] = 0;
                WinningIndexes[1, 0] = 2; WinningIndexes[1, 1] = 1;
                WinningIndexes[2, 0] = 2; WinningIndexes[2, 1] = 2;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if board is empty
        /// </summary>
        /// <returns>True if empty, False - otherwise</returns>
        public bool IsMovesLeft()
        {
            for (int i = 0; i < WIDTH; i++)
                for (int j = 0; j < HEIGHT; j++)
                    if (this[i,j] == ElementType.Empty)
                        return true;
            return false;
        }

        /// <summary>
        /// Match board with UI board
        /// </summary>
        /// <param name="buttons">UI array of buttons</param>
        public void Update(Button[,] buttons)
        {
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    var button = buttons[i, j];
                    switch (button.Text)
                    {
                        case "X": this[i, j] = ElementType.X; break;
                        case "O": this[i, j] = ElementType.O; break;
                        default:break;
                    }
                }
            }
        }

        /// <summary>
        /// Initialize all elements in array as ElementType.Empty
        /// </summary>
        public void Clean()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    this[i, j] = ElementType.Empty;
                }
            }
        }

        public enum ElementType { Empty, X, O };
    }
}
