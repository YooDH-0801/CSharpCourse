using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRpg.Interfaces;

namespace TextRpg.Core
{
    internal class Game
    {
        public bool IsRun { get; private set; } = false;
        public bool IsInitialized { get; private set; } = false;

        //TODO:: GameStateMachine 구현 필요
        private GameStateMachine _stateMachine;

        public void Run()
        {
            IsRun = true;
            Console.WriteLine("게임을 실행합니다.");
            Thread.Sleep(2000);

            _stateMachine = new GameStateMachine();

            while (IsRun)
            {
                Console.Clear();
                Render();
                string input = ReadCommand();
                Update(input);
            }

            Quit();
        }

        public void Render()
        {

        }

        public void Update(string command)
        {

        }

        public void Quit()
        {
            IsRun = false;
            Console.WriteLine();
            Console.WriteLine("게임을 종료합니다.");
        }

        private static string ReadCommand()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
