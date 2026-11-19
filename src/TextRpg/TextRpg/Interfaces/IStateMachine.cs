using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg.Interfaces
{
    public interface IStateMachine<TState>
    {
        public TState CurrentState { get; }

        public void ChangeState(TState newState);

        public void Enter();
        public void Render();
        public void Update(string command);
        public void Exit();
    }
}
