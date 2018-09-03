using System;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class HumanPlayer : Player
    {
        /// <summary>
        /// To make Task cancelation possible
        /// </summary>
        private CancellationTokenSource _cts;

        /// <summary>
        /// Endless loop until player clicks button
        /// </summary>
        /// <returns></returns>
        protected override Task MakeTurnAsync()
        {
            _cts = new CancellationTokenSource();

            var token = _cts.Token;

            var task = Task.Factory.StartNew(
                () =>
                {
                    while (true)
                    {
                        if (token.IsCancellationRequested)
                        {
                            break;
                        }
                    }
                }
            );

            return task;
        }

        /// <summary>
        /// Cancels task
        /// </summary>
        public override void OnPlayerMoved()
        {
            _cts?.Cancel();
        }
    }
}
