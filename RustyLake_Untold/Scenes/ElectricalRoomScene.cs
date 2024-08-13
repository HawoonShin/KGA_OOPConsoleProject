using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 전기실
    internal class ElectricalRoomScene : Scene
    {
        //복도와 연결

        //퓨즈박스
        //퍼즐이 복잡한 관게로 퓨즈를 하나 찾아오는 정도로 조건완화

        //선반
        // 주방 밸브 고정용 렌치 발견

        //파이프
        //아이템을 사용하여 때릴경우 산성액이 유출
        //산성액은 실험에 상용됨

        //환풍구
        //퓨즈 발견

        //땅의 얼룩
        //의미 없음

        private string input;

        public ElectricalRoomScene(Game game) :base(game) 
        {
           
        }

        // 정적함수?
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
