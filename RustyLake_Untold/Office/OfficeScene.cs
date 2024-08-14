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

        // 정적함수?
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("사무실은 깨긋하고 흰색 벽지로 이루어져 있다.");
            Console.WriteLine("그리고 방 한가운데에는 컴퓨터 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("다시 이전으로 돌아갑니다.");
            Console.WriteLine("1. 복도");
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
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
