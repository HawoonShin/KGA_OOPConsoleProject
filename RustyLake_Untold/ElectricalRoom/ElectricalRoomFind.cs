using RustyLake_Untold.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.ElectricalRoom
{
    internal class ElectricalRoomFind : Scene
    {
        // protected Game game;
        private string input;

        public ElectricalRoomFind(Game game) :base(game) 
        {
            //this.game = game;
        }

   
        public override void Enter() { }
        public override void Render() 
        {
            Console.WriteLine("주변을 조사합니다");
            Console.WriteLine("=================");
            Console.WriteLine("1. 퓨즈박스");
            Console.WriteLine("2. 선반");
            Console.WriteLine("3. 파이프");
            Console.WriteLine("4. 환풍구");
            Console.WriteLine("5. 땅의 얼룩");
            Console.WriteLine("=================");
            Console.WriteLine("0. 인벤토리 확인");
            Console.WriteLine("9. 뒤로가기");
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
                //퓨즈박스
                case "1":
                    //퓨즈 아이템을 소지할 경우
                    //불이 들어온다
                    //퓨즈가 없을 경우
                    Console.WriteLine("퓨즈가 하나 빠져 있는 것을 발견합니다.");
                    Console.WriteLine("하지만 넣을 퓨즈가 없습니다");
                    break;

                //선반
                case "2":
                    //렌치 아이템 습득
                    Console.WriteLine("선반에는 오직 렌치만이 덩그러니 놓여있습니다.");
                    Console.WriteLine("렌치를 얻었습니다.");
                    break;

                //파이프
                case "3":
                    //아이템에 렌치가 있을 경우
                    //렌치로 파이프를 때려 산성액 습득
                    //없을 경우
                    Console.WriteLine("파이프에는 금이 가 있습니다.");
                    Console.WriteLine("무언가 단단한걸로 내려 치면 곧 깨질거 같습니다.");
                    break;

                //환풍구
                //퓨즈 발견
                case "4":
                    //퓨즈 습득
                    Console.WriteLine("당신은 작은 환풍구를 들여다 봅니다.");
                    Console.WriteLine("환풍구 안쪽으로 퓨즈가 보입니다.");
                    Console.WriteLine("손을 뻗어 퓨즈를 얻었습니다.");
                    break;

                //땅의 얼룩
                case "5":
                    Console.WriteLine("바닥은 어쩐지 부식된것 같은 얼룩이 있다.");
                    Console.WriteLine("고개를 든 당신은 그 위가 파이프 인 것을 발견한다.");
                    break;
                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    game.ChangeScene(SceneType.ElectricalRoom);
                    break;
            }
        }
        public override void Exit() { }
    }
}
