using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Office
{
    // 사무실
    internal class OfficeScene : Scene
    {
        //복도 와 연결

        private string input;

        public OfficeScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 사무실은 깨끗하고 흰색 벽지로 이루어져 있다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 그리고 방 한가운데에는 컴퓨터 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("무엇을 하시겠습니까.");
            Console.WriteLine("========================");
            Console.WriteLine("1. 조사한다");
            Console.WriteLine("2. 복도로 돌아간다");
            Console.WriteLine("========================");
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
                    Console.WriteLine(" 사무실을 조사합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.OfficeFind); break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(" 당신은 복도로 돌아갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
