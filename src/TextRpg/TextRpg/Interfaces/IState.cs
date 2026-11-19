using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg.Interfaces
{
    internal interface IState<TStateMachine>
    {
        public TStateMachine StateMachine { get; }

        public void Enter();
        public void Render();
        public void Update(string command);
        public void Exit();
    }
}
