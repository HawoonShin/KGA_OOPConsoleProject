using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Bedroom
{
    // 침실
    public class BedroomScene : Scene
    {
        //시작화면
        //퍼즐을 풀면 복도로 연결
        // 특수 상황에 따라 히든 룸으로 연결

        //히든룸 조건
        //통풍구를 드라이버 소지시 열수 있다.
        //미로는 다른거 다 구현하면 만들도록

        private string input;

        public BedroomScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 눈을 뜬 당신의 앞에는 침실이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 침실은 어둡웠고, 네모나고 하얀 타일이 깔려있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 당신은 침대에서 일어났습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 어서 여기서 탈출해야만 할거 같습니다.");
            Thread.Sleep(3000); //잠시 글씨를 멈추게 한다
        }

        public override void Exit()
        {
            // Console.Clear();
            // Console.WriteLine("나가는 중입니다...");
            // Thread.Sleep(2000);
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("========================");
            //Console.WriteLine("0. 아이템을 확인한다.");
            Console.WriteLine("1. 주변을 조사한다");
            Console.WriteLine("2. 문을 열고 나간다");
            Console.WriteLine("========================");
            Console.Write("선택 :");
        }

        public override void Update()
        {
            switch (input)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("인벤토리를 확인합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "1":
                    Console.Clear();
                    Console.WriteLine(" 당신은 방을 둘러보기로 결정했습니다..");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.BedroomFind); break;
                case "2":
                    if (game.inventory.ItemCheck("침실 열쇠") == true)
                    {
                        Console.Clear();
                        Console.WriteLine(" 당신이 갖고 있던 열쇠는 방문에 딱 맞았습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 당신은 열쇠를 넣고 문을 열었습니다.");
                        Thread.Sleep(2000);
                        game.ChangeScene(SceneType.Hallway);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("열쇠가 없는 당신은 문을 열지 못합니다.");
                        Thread.Sleep(2000);
                    }
                    break;
                //임시 엔딩확인용 다이렉트 루트
                case "18":
                    game.ChangeScene(SceneType.Ending); break;
                    break;

            }
        }
    }
}
