using RustyLake_Untold.Scenes;


namespace RustyLake_Untold.Bedroom
{
    public class BedroomFind : Scene
    {
        //protected Game game;
        private string input;

        Inventory inventory;
        Item Item;

        public BedroomFind(Game game) : base(game)
        {
            //this.game = game;
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 눈 앞에 침실이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 눈앞에는 침대와 문, 수납형 옷장이 보입니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 벽에는 환풍구가 있고 cctv가 돌아갑니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 바닥에는 러그가 놓여있고 그 외에는 특별한 것은 보이지 않습니다 ");
            Thread.Sleep(3000); //잠시 글씨를 멈추게 한다
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("==============================");
            Console.WriteLine("1. 침대");
            Console.WriteLine("2. 문");
            Console.WriteLine("3. 옷장");
            Console.WriteLine("4. 환풍구");
            Console.WriteLine("5. CCTV");
            Console.WriteLine("6. 러그");
            Console.WriteLine("==============================");
            //Console.WriteLine("0. 인벤토리");
            Console.WriteLine("9. 방으로 돌아간다");
            Console.WriteLine("==============================");
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
                //침대에 힌트 1-1
                case "1":
                    // 힌트1-1 아이템 생성 추가할 것
                    Item hint2 = new Item(this);
                    hint2.id = 4;
                    hint2.name = "힌트가 적힌 종이2";
                    hint2.description = "\"267\"이라고 적힌 종이다.";

                    game.inventory.Add(hint2);

                    Console.Clear();
                    Console.WriteLine("메모지를 찾았습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("메모지에는 [267] 이라는 숫자만 적혀있습니다.");
                    Thread.Sleep(3000);
                    break;
                //문
                case "2":
                    if (game.inventory.ItemCheck("침실 열쇠") == true)
                    {
                        Console.Clear();
                        Console.WriteLine("당신은 열쇠로 이 문을 열수 있을 거 같습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("(조사 화면을 나가서 열쇠를 사용해 주세요.)");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("열쇠로 열리는 문 같습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("열쇠를 찾아야합니다.");
                        Thread.Sleep(2000);

                    }
                    break;
                case "3":
                    game.ChangeScene(SceneType.BedroomDresser);
                    break;
                //환풍구
                case "4":
                    //드라이버 소지시 오픈가능
                    if (game.inventory.ItemCheck("드라이버") == true)
                    {
                        // 안쪽은 미로
                        // 미로는 시간상 구현하지 못함
                        Console.Clear();
                        Console.WriteLine(" 당신은 드라이버로 환풍구를 열었습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 어둡고 먼지가 가득한 공간입니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 당신은 감각에 의지하며 앞으로 기어 나갑니다.");
                        Thread.Sleep(2000);
                        game.ChangeScene(SceneType.HiddenRoom);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" 환풍구는 사람이 들어갈 정도로 입구가 커 보입니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 하지만 지금은 할 수 있는게 없습니다.");
                        Thread.Sleep(2000);
                    }
                    break;
                // 카메라 
                case "5":
                    Console.Clear();
                    Console.WriteLine(" cctv는 조용히 천장에 매달려 있습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 어쩐지 기분나쁜 시선이 느껴지는 것 같습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 그 외 특별한 점은 없는 것 같습니다.");
                    Thread.Sleep(2000);
                    break;
                //러그
                case "6":
                    //if손전등이 있을 경우 힌트제공
                    //원래는 힌트를 주는 공간이었지만 임시로 스토리에 연관된 문구 출력
                    if (game.inventory.ItemCheck("손전등") == true)
                    {
                        Console.Clear();
                        Console.WriteLine(" 당신은 가지고 있던 손정등으로 아래를 비추어 봅니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 아래를 비추자 어떠한 문구가 보입니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" [침대]+[옷장]");
                    }

                    //없을 경우 
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" 밑 쪽에 공간을 발견합니다!");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 하지만 너무 어두워서 무언가 필요할 것 같습니다.");
                        Thread.Sleep(2000);
                    }
                    break;
                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    game.ChangeScene(SceneType.Bedroom);
                    break;
            }
        }
        public override void Exit() { }
    }
}
