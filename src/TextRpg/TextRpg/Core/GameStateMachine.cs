using TextRpg.Interfaces;

namespace TextRpg.Core
{
    public sealed class GameStateMachine : IStateMachine<GameState>
    {
        public GameStateMachine()
        {
            
        }

        private GameState _curGameState;

        GameState IStateMachine<GameState>.CurrentState => _curGameState;

        void IStateMachine<GameState>.ChangeState(GameState newState)
        {
            throw new NotImplementedException();
        }

        void IStateMachine<GameState>.Enter()
        {
            throw new NotImplementedException();
        }

        void IStateMachine<GameState>.Exit()
        {
            throw new NotImplementedException();
        }

        void IStateMachine<GameState>.Render()
        {
            throw new NotImplementedException();
        }

        void IStateMachine<GameState>.Update(string command)
        {
            throw new NotImplementedException();
        }
    }
}
