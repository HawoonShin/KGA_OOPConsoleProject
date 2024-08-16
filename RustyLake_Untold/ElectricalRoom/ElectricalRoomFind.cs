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
        Inventory inventory;
        Item Item;

        public ElectricalRoomFind(Game game) :base(game) 
        {
            //this.game = game;
        }

   
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine(" 방 한가운데에는 퓨즈박스가 자리하고 그 옆으로 선반이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 방에는 환풍기가 있고 바닥은 얼룩같은 것이 있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("=========================");
            Console.WriteLine("1. 퓨즈박스");
            Console.WriteLine("2. 선반");
            Console.WriteLine("3. 파이프");
            Console.WriteLine("4. 환풍구");
            Console.WriteLine("5. 땅의 얼룩");
            Console.WriteLine("=========================");
            //Console.WriteLine("0. 인벤토리 확인");
            Console.WriteLine("9. 뒤로가기");
            Console.WriteLine("=========================");
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
                    if(game.inventory.ItemCheck("퓨즈") == true)
                    {
                        //불이 들어온다
                        Console.Clear();
                        Console.WriteLine(" 퓨즈박스에 작은 스파크가 튑니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 곧이어 작은 웅웅소리와 함께 전등이 켜지기 시작합니다.");
                        Thread.Sleep(2000);
                    }

                    //퓨즈가 없을 경우
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" 퓨즈가 하나 빠져 있는 것을 발견합니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 하지만 넣을 퓨즈가 없습니다");
                        Thread.Sleep(2000);
                    }
                    break;

                //선반
                case "2":
                    //렌치 아이템 습득
                    Console.Clear();
                    Console.WriteLine(" 선반에는 오직 렌치만이 덩그러니 놓여있습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 렌치를 얻었습니다.");
                    Thread.Sleep(2000);

                    Item Wrench = new Item(this);
                    Wrench.id = 6;
                    Wrench.name = "렌치";
                    Wrench.description = "단단해 보이는 렌치이다.";

                    game.inventory.Add(Wrench);
                    break;

                //파이프
                case "3":
                    //아이템에 렌치가 있을 경우
                    if(game.inventory.ItemCheck("렌치")==true)
                    {
                        //렌치로 파이프를 때려 산성액 습득
                        Console.Clear();
                        Console.WriteLine(" 당신은 갖고있던 렌치로 파이프를 때렸습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 파이프의 균열이 더 커지고 그곳에서 산성액이 흘러나옵니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 당신은 이 산성액을 챙깁니다.");
                        Thread.Sleep(2000);

                        Item acid = new Item(this);
                        acid.id = 7;
                        acid.name = "산성액";
                        acid.description = "산성액입니다. 약간 이상한 냄새가 납니다.";

                        game.inventory.Add(acid);
                    }
                    //없을 경우
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine(" 파이프에는 금이 가 있습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 무언가 단단한걸로 내려 치면 곧 깨질거 같습니다.");
                        Thread.Sleep(2000);
                    }
                    break;

                //환풍구
                //퓨즈 발견
                case "4":
                    //퓨즈 습득
                    Item fuse = new Item(this);
                    fuse.id = 8;
                    fuse.name = "퓨즈";
                    fuse.description = "퓨즈입니다. 퓨즈박스에서 사용할 수 있을거 같습니다.";

                    game.inventory.Add(fuse);

                    Console.Clear();
                    Console.WriteLine(" 당신은 작은 환풍구를 들여다 봅니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 환풍구 안쪽으로 퓨즈가 보입니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 손을 뻗어 퓨즈를 얻었습니다.");
                    Thread.Sleep(2000);
                    break;

                //땅의 얼룩
                case "5":
                    Console.Clear();
                    Console.WriteLine(" 바닥은 어쩐지 부식된것 같은 얼룩이 있다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 고개를 든 당신은 그 위가 파이프 인 것을 발견한다.");
                    Thread.Sleep(2000);
                    break;
                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    Console.Clear();
                    Console.WriteLine(" 돌아갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.ElectricalRoom);
                    break;
            }
        }
        public override void Exit() { }
    }
}
