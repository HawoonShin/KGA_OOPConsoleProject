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
            Console.WriteLine(" 문이 삐걱거리는 소리와 함께 열립니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 문을 열자 알수없는 퀴퀴한 냄새가 풍겨옵니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 방은 전선과 파이프로 어수선합니다.");
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
                    Console.WriteLine(" 당신은 부엌을 둘러보기로 결정했습니다..");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.ElectricalRoomFind); break; 
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
