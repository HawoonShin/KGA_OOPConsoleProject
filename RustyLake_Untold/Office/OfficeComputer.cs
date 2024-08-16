using RustyLake_Untold.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Office
{
    internal class OfficeComputer : Scene
    {
        private string input;
        public OfficeComputer(Game game) : base(game)
        {
            //this.game = game;
        }

        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine(" 컴퓨터의 암호가 해제 되었습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 컴퓨터의 화면에는 두가지 아이콘이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 하나는 텍스트 아이콘과 카메라의 아이콘이 있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("어느 것을 확인하시겠습니까?");
            Console.WriteLine("=======================");
            Console.WriteLine("1. 텍스트 파일");
            Console.WriteLine("2. 카메라 아이콘");
            Console.WriteLine("=======================");
            //Console.WriteLine("0. 아이템 확인");
            Console.WriteLine("9. 뒤로 가기");
            Console.WriteLine("=======================");
            Console.Write("선택 :");
        }
        public override void Input() 
        {
            input = Console.ReadLine();
        }
        public override void Update() 
        {
            switch (input) 
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(" 당신은 텍스트 파일을 열었습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 화면에는 다음과 같은 문구가 나옵니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("===================================");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  I DO REMEMBER                  ");
                    Console.ResetColor();
                    Console.WriteLine("===================================");
                    Thread.Sleep(3000);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(" 당신은 카메라를 열였습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 그러자 화면에는 4개의 장면이 보였습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 3개의 화면은 각각 침실, 주방, 화학 실험실이었고,");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 1개의 화면은 당신이 전혀 가보지 못한 곳이 비춥니다.");
                    Thread.Sleep(2000);
                    break;
                case "0":
                    //game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    Console.Clear();
                    Console.WriteLine(" 사무실로 돌아갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.OfficeFind);
                    break;
            }
        }
        public override void Exit() { }
    }
}
