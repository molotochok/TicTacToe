using System;
using System.Windows.Forms;

namespace TicTacToe
{
    class Presenter
    {
        private IMainForm _view;

        private bool _playerUseX = true;

        private TicTacToe _ticTacToe;
        private Board  _board = new Board();

        public Presenter(IMainForm view)
        {
            _view = view;

            _view.BtnChooseX.Enabled = false;
            _view.BtnChooseX.BackColor = System.Drawing.Color.DarkGray;

            _view.ComboBoxOpponentChanged += _view_ComboBoxOpponentChanged;
            _view.BtnChooseXClicked       += _view_BtnChooseXClicked;
            _view.BtnChooseOClicked       += _view_BtnChooseOClicked;
            _view.BtnConfirmClicked       += _view_BtnConfirmClicked;
            _view.BtnClicked              += _view_BtnClicked;
            _view.BtnBackClicked          += _view_BtnBackClicked;
            _view.BtnRefreshClicked       += _view_BtnRefreshClicked;     

            _view.ComboBoxOpponent.DataSource   = Enum.GetValues(typeof(PlayerType));
            _view.ComboBoxDifficulty.DataSource = Enum.GetValues(typeof(DifficultyType));
        }

        // ----------- CallBackMethods -----------
        #region CallBackMethods
        private void _view_BtnRefreshClicked(object sender, EventArgs e)
        {
            _view.LabelTurn.Text = "X moves";
            StartGame();
        }

        private void _view_BtnBackClicked(object sender, EventArgs e)
        {
            _view.PanelMenu.Show();
            _ticTacToe.Reset();

            _board.Clean();
            

            _view.LabelTurn.Text = "X moves";

        }

        private void _view_BtnChooseOClicked(object sender, EventArgs e)
        {
            _view.BtnChooseO.Enabled = false;
            _view.BtnChooseX.Enabled = true;

            _view.BtnChooseO.BackColor = System.Drawing.Color.DarkGray;
            _view.BtnChooseX.BackColor = System.Drawing.Color.WhiteSmoke;

            _playerUseX = false;
        }

        private void _view_BtnChooseXClicked(object sender, EventArgs e)
        {
            _view.BtnChooseO.Enabled = true;
            _view.BtnChooseX.Enabled = false;

            _view.BtnChooseX.BackColor = System.Drawing.Color.DarkGray;
            _view.BtnChooseO.BackColor = System.Drawing.Color.WhiteSmoke;

            _playerUseX = true;
        }

        private void _view_ComboBoxOpponentChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            Enum.TryParse(comboBox.SelectedValue.ToString(), out PlayerType playerType);
            if (playerType == PlayerType.Computer)
            {
                _view.GroupBoxDifficulty.Show();
            }
            else
            {
                _view.GroupBoxDifficulty.Hide();
            }
        }
        private void _view_BtnClicked(object sender, EventArgs e)
        {
            _view.BtnRefresh.Enabled = true; 

            Button button = (Button)sender;
            button.Enabled = false;

            if(_ticTacToe.CurrentTurn == TicTacToe.Turn.PlayerX)
            {
                button.Text = "X";
                _view.LabelTurn.Text = "O moves";
            }
            else
            {
                button.Text = "O";
                _view.LabelTurn.Text = "X moves";
            }

            _ticTacToe.PlayerMoved();
            _ticTacToe.UpdateBoard(_view.BtnsTicTacToe);
        }

        private void _view_BtnConfirmClicked(object sender, EventArgs e)
        {
            _view.PanelMenu.Hide();

            StartGame();
        }

        /// <summary>
        /// If UIBoard changes - change board so that they are matched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ticTacToe_UIBoardChanged(object sender, EventArgs e)
        {
            Action action = () =>
            {
                var board = (Board)sender;

                for (var i = 0; i < _board.WIDTH; i++)
                {
                    for (var j = 0; j < _board.HEIGHT; j++)
                    {
                        if (board[i, j] == Board.ElementType.X)
                        {
                            _view.BtnsTicTacToe[i, j].Text = "X";
                            _view.BtnsTicTacToe[i, j].Enabled = false;
                        }
                        else if (board[i, j] == Board.ElementType.O)
                        {
                            _view.BtnsTicTacToe[i, j].Text = "O";
                            _view.BtnsTicTacToe[i, j].Enabled = false;
                        }
                    }
                }
            };
            _view.ExecuteDelegateOnUIThread(action);
        }

        private void _ticTacToe_GameFinishedTie(string message)
        {
            _view.LabelTurn.Text = message;
        }

        private void _ticTacToe_GameFinishedWin(string message, Int32[,] winningIndexes)
        {
            _view.LabelTurn.Text = message;

            for (var i = 0; i < _board.WIDTH; i++)
            {
                Int32 x = winningIndexes[i, 0];
                Int32 y = winningIndexes[i, 1];

                _view.BtnsTicTacToe[x, y].BackColor = System.Drawing.Color.AliceBlue;
            }

            for (var i = 0; i < _board.WIDTH; i++)
            {
                for (var j = 0; j < _board.HEIGHT; j++)
                {
                    _view.BtnsTicTacToe[i, j].Enabled = false;
                }
            }
        }
        #endregion

        // ----------- Other Methods -----------
        private void RefreshButtons()
        {
            for (int i = 0; i < _board.WIDTH; i++)
            {
                for (int j = 0; j < _board.HEIGHT; j++)
                {
                    _view.BtnsTicTacToe[i, j].BackColor = System.Drawing.Color.Gray;
                    _view.BtnsTicTacToe[i, j].Text = "";
                    _view.BtnsTicTacToe[i, j].Enabled = true;
                }
            }
        }

        /// <summary>
        /// Starts game
        /// </summary>
        private void StartGame()
        {
            _ticTacToe?.Reset();
            _view.BtnRefresh.Enabled = false;
            _board.Clean();
            RefreshButtons();

            var opponentComboBox = _view.ComboBoxOpponent;
            Enum.TryParse(opponentComboBox.SelectedItem.ToString(), out PlayerType opponentType);

            var difficultyComboBox = _view.ComboBoxDifficulty;
            Enum.TryParse(difficultyComboBox.SelectedItem.ToString(), out DifficultyType difficultyType);

            Player player1 = new HumanPlayer();
            Player player2 = null;
            if (opponentType == PlayerType.Human)
            {
                player2 = new HumanPlayer();
            }
            else
            {
                player2 = new ComputerPlayer(difficultyType);
            }

            player1.PlayersTurn = TicTacToe.Turn.PlayerX;
            player2.PlayersTurn = TicTacToe.Turn.PlayerO;

            _ticTacToe = new TicTacToe(_board, player1, player2, difficultyType);
            _ticTacToe.GameFinishedWin += _ticTacToe_GameFinishedWin;
            _ticTacToe.GameFinishedTie += _ticTacToe_GameFinishedTie;
            _ticTacToe.UIBoardChanged += _ticTacToe_UIBoardChanged; ;

            if (!_playerUseX)
            {
                player2.PlayersTurn = TicTacToe.Turn.PlayerX;
                player1.PlayersTurn = TicTacToe.Turn.PlayerO;

                _ticTacToe.PlayerX = player2;
                _ticTacToe.PlayerO = player1;
            }

            _ticTacToe.Start();
        }
    }
}