using System.Windows.Forms;
using System;

namespace TicTacToe
{
    internal class TicTacToe
    {
        private Board _board;

        public Player PlayerX { get; set; }
        public Player PlayerO { get; set; }

        public DifficultyType Difficulty { get; set; }

        public Turn CurrentTurn { get; private set; }

        public event Action<string, Int32[,]> GameFinishedWin;
        public event Action<string> GameFinishedTie; 
        public event EventHandler UIBoardChanged;

        private bool _isGameRunning;

        public TicTacToe(Board board, Player playerX, Player playerO, DifficultyType difficulty)
        {
            _isGameRunning = true;
            _board = board;
            _board.BoardChanged += _board_BoardChanged; ;

            CurrentTurn = Turn.PlayerX;
            Difficulty = difficulty;

            PlayerX = playerX;
            PlayerO = playerO;

            PlayerX.CurrentBoard = _board;
            PlayerO.CurrentBoard = _board;
        }

        // Callback methods
        private void _board_BoardChanged(object sender, EventArgs e)
        {
            UIBoardChanged(sender, e);
        }

        // Other methods

        /// <summary>
        /// Start the game
        /// </summary>
        public async void Start()
        {
            while (_isGameRunning)
            {
                if (CurrentTurn == Turn.PlayerX)
                {
                    await PlayerX.MoveAsync();

                    if (_board.IsWin(Board.ElementType.X))
                    {
                        GameOver("X wins!!!", _board.WinningIndexes);
                        break;
                    }

                    CurrentTurn = Turn.PlayerO;
                }
                else
                {
                    await PlayerO.MoveAsync();

                    if (_board.IsWin(Board.ElementType.O))
                    {
                        GameOver("O wins!!!", _board.WinningIndexes);
                        break;
                    }

                    CurrentTurn = Turn.PlayerX;
                }

                if (!_board.IsMovesLeft())
                {
                    GameOver("Tie");
                    break;
                }
            }
        }

        /// <summary>
        /// Game over and there is winner
        /// </summary>
        /// <param name="message"></param>
        /// <param name="winningIndexes"></param>
        private void GameOver(string message, Int32[,] winningIndexes)
        {
            Reset();
            GameFinishedWin.Invoke(message, winningIndexes);
        }
        /// <summary>
        /// Gamee over and there is tie
        /// </summary>
        /// <param name="message"></param>
        private void GameOver(string message)
        {
            Reset();
            GameFinishedTie.Invoke(message);
        }
        
        public void UpdateBoard(Button[,] buttons)
        {
            _board.Update(buttons);
        }


        public void PlayerMoved()
        {
            if(CurrentTurn == Turn.PlayerX)
            {
                if(PlayerX.GetType() == typeof(HumanPlayer))
                {
                    PlayerX.OnPlayerMoved();
                }
            }
            else
            {
                if (PlayerO.GetType() == typeof(HumanPlayer))
                {
                    PlayerO.OnPlayerMoved();
                }
            }
        }

        public void Reset()
        {
            _isGameRunning = false;
            PlayerMoved();
            _board.Clean();
            CurrentTurn = Turn.PlayerX;
        }

        public enum Turn { PlayerX, PlayerO};
    }
}
