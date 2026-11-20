using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TextRPG.Framework
{
    internal class Debug
    {
        // 1. 일반 로그 (흰색/기본색)
        public static void Log(object message)
        {
            PrintWithColor("[LOG]", message?.ToString() ?? "null", ConsoleColor.White);
        }

        // 2. 경고 로그 (노란색)
        public static void LogWarning(object message)
        {
            PrintWithColor("[WARNING]", message?.ToString() ?? "null", ConsoleColor.Yellow);
        }

        // 3. 오류 로그 (빨간색)
        public static void LogError(object message)
        {
            PrintWithColor("[ERROR]", message?.ToString() ?? "null", ConsoleColor.Red);
        }

        // 4. 예외 로그 (어두운 빨간색 + 스택 트레이스 출력)
        public static void LogException(Exception exception)
        {
            if (exception == null) return;
            string detail = $"{exception.GetType().Name}: {exception.Message}\n{exception.StackTrace}";
            PrintWithColor("[EXCEPTION]", detail, ConsoleColor.DarkRed);
        }

        // 5. 단언(Assert) 로그 (조건이 false일 때만 자홍색으로 오류 출력)
        // [Conditional("DEBUG")] 특성을 붙여 릴리스 빌드 시 자동 제외되도록 구현
        [Conditional("DEBUG")]
        public static void Assert(bool condition, object message = null)
        {
            if (!condition)
            {
                string msg = message != null ? $"Assertion failed: {message}" : "Assertion failed!";
                PrintWithColor("[ASSERT]", msg, ConsoleColor.Magenta);
            }
        }

        // 포맷 지정 로그 지원
        public static void LogFormat(string format, params object[] args)
        {
            Log(string.Format(format, args));
        }

        // 콘솔 색상을 변경해 출력 후 원래 색상으로 복구하는 내부 헬퍼
        private static void PrintWithColor(string prefix, string message, ConsoleColor color)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {prefix} {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
