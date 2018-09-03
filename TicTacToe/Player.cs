using System.Threading.Tasks;

namespace TicTacToe
{
    internal abstract class Player
    {
        public Board CurrentBoard { get; set; }
        public TicTacToe.Turn PlayersTurn { get; set; }

        protected bool _alreadyMoved = false;

        /// <summary>
        /// Make Move asyncroniously for Player
        /// </summary>
        /// <returns></returns>
        public async Task MoveAsync()
        {
            await MakeTurnAsync();
        }

        /// <summary>
        /// Make children decide how to move asyncroniously 
        /// </summary>
        /// <returns></returns>
        protected abstract Task MakeTurnAsync();

        /// <summary>
        /// Triggers when played moved
        /// </summary>
        public abstract void OnPlayerMoved();
    }
}