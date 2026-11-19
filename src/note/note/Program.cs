// 주석 comment

/*
 *  2026-11-18
 *  키워드 : namespace , internal , class, static, void, string 문법
 * 
 *  note : 키워드 문법에 따라서 결정된 이름 
 *  Program : 클래스. 
 *  Main( )  / WriteLine( )
 */

/*
 *  게임에서 처음에 게임 제목 타이틀이 나오고 그 아래에 플레이가 가능한 플레이어 이름 만드는거 구현해보세요?
 *  
 *  제목 문자열
 *  
 *  <입출력>
 *  step1. 자연어 -> 프로그래밍 언어 바꾸고 -> 실행 가능한가?
 *  step2. 효율적인가? 왜 이런 이유로 선택했는지 근거를 말할 수 있는가? - 알고리즘
 *  
 *  [모험가 길드 ver] [1.00]
 *  
 */

using note.Part1;

namespace note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var part1_1 = new Part1_1();
            var part1_2 = new Part1_2();

            part1_1.Execute();
            part1_2.Execute();
        }
    }
}