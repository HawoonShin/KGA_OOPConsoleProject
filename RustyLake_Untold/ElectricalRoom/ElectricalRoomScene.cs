using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.ElectricalRoom
{
    // 전기실
    internal class ElectricalRoomScene : Scene
    {
        //복도와 연결

        private string input;

        public ElectricalRoomScene(Game game) : base(game)
        {

        }

     
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("퀴퀴한 냄새가 나는 '실험실'이다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("다른 방으로 이동합니다.");
            Console.WriteLine("1. 조사");
            Console.WriteLine("2. 복도");
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
                    game.ChangeScene(SceneType.ElectricalRoomFind); break; 
                case "2":
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
