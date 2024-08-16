using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Kitchen
{
    internal class KitchenFind : Scene
    {
        //protected Game game;
        private string input;
        Inventory inventory;
        Item Item;
        public KitchenFind(Game game) : base(game)
        {
            //  this.game = game;
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("주변을 둘러보자 옷이 걸린 의자와 작은 테이블이 보이고");
            Thread.Sleep(2000);
            Console.WriteLine("테이블 위로는 아이스박스가 보입니다");
            Thread.Sleep(2000);
            Console.WriteLine("싱크대에는 커피메이커가 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("구석에는 쓰레기통이 있고 벌레가 윙윙거립니다.");
            Thread.Sleep(2000);
            Console.WriteLine("벽에는 환풍기와 전화기도 있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("=======================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("=======================");
            Console.WriteLine("1. 코트");
            Console.WriteLine("2. 싱크대");
            Console.WriteLine("3. 커피메이커");
            Console.WriteLine("4. 쓰레기통");
            Console.WriteLine("5. 아이스박스");
            Console.WriteLine("6. 전화기");
            Console.WriteLine("=======================");
            //Console.WriteLine("0. 인벤토리 확인");
            Console.WriteLine("9. 부엌으로 돌아간다");
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
                //코트
                case "1":
                    Console.Clear();
                    Console.WriteLine("의자에 걸려있던 실험복을 조사 했지만");
                    Thread.Sleep(2000);
                    Console.WriteLine("실험복에 특별한 건 없었다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("다만 실험복의 신분증에는 R.Venderboom 이라고 써있었다.");
                    Thread.Sleep(2000);
                    break;

                //싱크대
                case "2":
                    //전기실에서 찾은 렌치로 고칠수 있다
                    if (game.inventory.ItemCheck("렌치") == true)
                    {
                        //그러면 물이 나온다.
                        Console.Clear();
                        Console.WriteLine("당신은 갖고 있던 렌치로 싱크대 밑의 관을 고쳤습니다. ");
                        Thread.Sleep(2000);
                        Console.WriteLine("수도꼭지에서는 곧 물이 나오기 시작했습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("당신은 물을 얻었습니다");
                        Thread.Sleep(2000);

                        Item water = new Item(this);
                        water.id = 9;
                        water.name = "물";
                        water.description = "그냥 물이다.";

                        game.inventory.Add(water);
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("물이 나오지 않습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("세면대의 아래 벨브를 고치면 나올 것 같습니다.");
                        Thread.Sleep(2000);
                    }
                    break;

                // 커피 메이커
                case "3":
                    // 전원을 복구해야한다(전기실)
                    // 휴지통에서 커피필터 아이템 구하기
                    //물탱크에 물 채우기
                    if (game.inventory.ItemCheck("물") == true &&
                       game.inventory.ItemCheck("커피 필터") == true &&
                       game.inventory.ItemCheck("전기 연결") == true)
                    {
                        Console.Clear();
                        Console.WriteLine("당신은 커피 메이커를 사용합니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("커피 필터를 끼우고 옆에 놓여있던 커피 가루를 집어 넣습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("물을 채우고 커피가 내리길 잠시 기다립니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("향기로운 커피향과 함께 커피가 만들어졌습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("당신은 커피를 얻었습니다.");

                        // 만들어진 커피는 실험에 사용
                        Item coffee = new Item(this);
                        coffee.id = 11;
                        coffee.name = "커피";
                        coffee.description = "향기로운 커피입니다.";

                        game.inventory.Add(coffee);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("커피 메이커를 사용하기엔 무언가 더 필요할 것 같다..");
                        Thread.Sleep(2000);
                    }
                    break;

                //쓰레기통 
                case "4":
                    // 커피 필터 가 새것과 사용한것이 뒤엉켜 있다.
                    Console.Clear();
                    Console.WriteLine("쓰레기통에는 날벌레가 날아다닙니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("그 안쪽으로 커피 필터들이 새 것과 사용한 것이 뒤엉켜 있습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("커피 필터를 얻었습니다.");
                    Thread.Sleep(2000);

                    Item coffeeFilter = new Item(this);
                    coffeeFilter.id = 10;
                    coffeeFilter.name = "커피 필터";
                    coffeeFilter.description = "그럭저럭 쓸만한 커피 필터이다.";

                    game.inventory.Add(coffeeFilter);
                    break;

                //아이스박스
                case "5":
                    // 코드는 cold (실험실에서 힌트 입수)(아이템말고 코드입력으로)
                    // 얼음 입수
                    Console.Clear();
                    Console.WriteLine("아이스박스로 보이는 것은 잠겨 있습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("비밀 번호를 입력하는 곳이 있습니다.");
                    Thread.Sleep(2000);
                    Console.Write("코드 입력 :(COLD)");
                    string input2 = Console.ReadLine();
                    if (input2 == "COLD")
                    {
                        Console.WriteLine("안쪽에는 얼음이 들어있습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("얼음을 얻었습니다");
                        Thread.Sleep(2000);

                        Item ice = new Item(this);
                        ice.id = 12;
                        ice.name = "얼음";
                        ice.description = "시원한 상태로 보존되던 얼음 입니다.";

                        game.inventory.Add(ice);
                    }
                    else
                    {
                        Console.WriteLine("틀린것 같다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("열리지 않는다.");
                        Thread.Sleep(2000);
                    }

                    break;

                //전화기
                case "6":
                    // 전원 복원시 사용가능
                    // 사무실의 번호로 전화 가능
                    if(game.inventory.ItemCheck("전기 연결")==true)
                    {

                    Console.Clear();
                    Console.WriteLine("당신은 수화기를 들고 번호를 누르기 시작합니다.");
                    Console.Write("입력 :(099174190)");
                    int.TryParse(Console.ReadLine(), out int phoneNumber);
                    // 그때 3141 코드 주어짐(사무실 컴퓨터에 사용)
                    if (phoneNumber == 099174190)
                    {
                        Console.WriteLine("전화가 연결되었습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("치지직 거리는 소음과 웅성거리는 소리가 들립니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("자세히 들으려하지만 잘 들리지 않습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine("그때 분명한 발음으로 누군가 말을 합니다.");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[3.1.4.1]");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.WriteLine("그리고 전화는 끊어집니다.");
                        Thread.Sleep(2000);
                    }
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("잘.못.거.셨.습.니.다.");
                            Thread.Sleep(2000);
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("전화기는 반응이 없습니다.");
                        Thread.Sleep(2000);

                    }
                    break;
                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    game.ChangeScene(SceneType.Kitchen);
                    break;
            }
        }
        public override void Exit() { }
    }
}
