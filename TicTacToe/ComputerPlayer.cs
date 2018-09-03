using System;
using System.Threading.Tasks;

namespace TicTacToe
{
    class ComputerPlayer : Player
    {
        // Const values
        private const Int32 BEST_VALUE = 1000;
        private const Int32 WORST_VALUE = -1000;
        private const Int32 VICTORY_VALUE = 10;

        // Events
        private event Action<Move> BestMoveFound;

        private bool _isFirstTurn = true;
        private Board.ElementType _computer = Board.ElementType.O;
        private Board.ElementType _opponent = Board.ElementType.X;
        
        private DifficultyType _difficulty;

        public ComputerPlayer(DifficultyType difficulty)
        {
            _difficulty = difficulty;

            BestMoveFound += ComputerPlayer_BestMoveFound;
        }

        private void ComputerPlayer_BestMoveFound(Move bestMove)
        {
            CurrentBoard[bestMove.Row, bestMove.Col] = _computer;
            CurrentBoard.UpdateBoardUI();
        }

        protected override Task MakeTurnAsync()
        {
            Action action = () =>
            {
                if(PlayersTurn == TicTacToe.Turn.PlayerX)
                {
                    _computer = Board.ElementType.X;
                    _opponent = Board.ElementType.O;
                }
                else
                {
                    _isFirstTurn = false;
                    _computer = Board.ElementType.O;
                    _opponent = Board.ElementType.X;
                }

                var bestMove = new Move();
                if (_isFirstTurn)
                {
                    bestMove = Move.Random(0, 2, 0, 2);
                    _isFirstTurn = false;
                }
                else
                {
                    var maxDepth = 0;
                    switch (_difficulty)
                    {
                        case DifficultyType.Easy:
                            maxDepth = 1;
                            break;
                        case DifficultyType.Medium:
                            maxDepth = 4;
                            break;
                        case DifficultyType.Hard:
                            maxDepth = 7;
                            break;
                        default:
                            break;
                    }

                    bestMove = FindBestMove(CurrentBoard, maxDepth);
                }

                BestMoveFound.Invoke(bestMove);
            };
            var task = Task.Factory.StartNew(action);

            return task;
        }

        public override void OnPlayerMoved()
        {
            throw new NotImplementedException();
        }

        // Methods that helps finding best move
        #region BestMoveCalculation
        private Move FindBestMove(Board board, Int32 maxDepth)
        {
            Int32 bestVal = WORST_VALUE;
            Move bestMove = new Move
            {
                Row = -1,
                Col = -1
            };

            for (var i = 0; i < board.WIDTH; i++)
            {
                for (var j = 0; j < board.HEIGHT; j++)
                {
                    if (board[i, j] == Board.ElementType.Empty)
                    {
                        board[i, j] = _computer;

                        Int32 moveVal = Minimax(board, 0, maxDepth, false);

                        board[i, j] = Board.ElementType.Empty;

                        if (moveVal > bestVal)
                        {
                            bestMove.Row = i;
                            bestMove.Col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }

            return bestMove;
        }

        private Int32 Minimax(Board board, Int32 depth, Int32 maxDepth, bool isMax)
        {
            Int32 score = Evaluate(board);

            if (score == VICTORY_VALUE || score == -VICTORY_VALUE)
                return score - depth;

            if (!board.IsMovesLeft() || depth == maxDepth)
                return 0;

            if (isMax)
            {
                Int32 best = WORST_VALUE;

                for (Int32 i = 0; i < board.WIDTH; i++)
                {
                    for (Int32 j = 0; j < board.HEIGHT; j++)
                    {
                        if (board[i, j] == Board.ElementType.Empty)
                        {
                            board[i, j] = _computer;

                            best = Math.Max(best,
                                Minimax(board, depth + 1, maxDepth, !isMax));
                            board[i, j] = Board.ElementType.Empty;
                        }
                    }
                }
                return best;
            }
            else
            {
                Int32 best = BEST_VALUE;

                for (Int32 i = 0; i < board.WIDTH; i++)
                {
                    for (Int32 j = 0; j < board.HEIGHT; j++)
                    {
                        if (board[i, j] == Board.ElementType.Empty)
                        {
                            board[i, j] = _opponent;

                            best = Math.Min(best, Minimax(board, depth + 1, maxDepth, !isMax));

                            board[i, j] = Board.ElementType.Empty;
                        }
                    }
                }
                return best;
            }
        }
        private Int32 Evaluate(Board board)
        {
            // Horizontal
            for (var row = 0; row < board.WIDTH; row++)
            {
                if (board[row, 0] == board[row, 1] &&
                    board[row, 1] == board[row, 2])
                {
                    if (board[row, 0] == _computer)
                        return VICTORY_VALUE;
                    else if (board[row, 0] == _opponent)
                        return -VICTORY_VALUE;
                }
            }

            // Vertical
            for (Int32 col = 0; col < board.HEIGHT; col++)
            {
                if (board[0, col] == board[1, col] &&
                    board[1, col] == board[2, col])
                {
                    if (board[0, col] == _computer)
                        return VICTORY_VALUE;

                    else if (board[0, col] == _opponent)
                        return -VICTORY_VALUE;
                }
            }

            // Diagonal checking
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == _computer)
                    return VICTORY_VALUE;
                else if (board[0, 0] == _opponent)
                    return -VICTORY_VALUE;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == _computer)
                    return VICTORY_VALUE;
                else if (board[0, 2] == _opponent)
                    return -VICTORY_VALUE;
            }

            return 0;
        }
        #endregion

        /// <summary>
        /// Coordinates x and y of the board
        /// </summary>
        private struct Move
        {
            public Int32 Row { get; set; }
            public Int32 Col { get; set; }

            public static Move Random(Int32 minRow, Int32 maxRow, Int32 minCol, Int32 maxCol)
            {
                Random random = new Random();

                Int32 row = random.Next(minRow, maxRow);
                Int32 col = random.Next(minCol, maxCol);

                Move move = new Move()
                {
                    Row = row,
                    Col = col
                };

                return move; 
            }
        };
    }
}