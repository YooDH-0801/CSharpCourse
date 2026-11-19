using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg.Interfaces;

namespace TextRpg.Core
{
    public abstract class GameState : IState<Game>
    {
        public GameState(IStateMachine<GameState> stateMachine)
        {
            _stateMachine = stateMachine;
        }

        protected IStateMachine<GameState> _stateMachine;
        Game IState<Game>.StateMachine => (Game) _stateMachine;

        public abstract void Enter();
        public abstract void Exit();
        public abstract void Update(string command);
        public abstract void Render();
    }
}
