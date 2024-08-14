using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Kitchen
{
    internal class KitchenFind : Scene
    {
        //protected Game game;
        private string input;

        public KitchenFind(Game game) : base(game)
        {
            //  this.game = game;
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("부엌 묘사");
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("조사할 곳을 선택해 주세요.");
            Console.WriteLine("=======================");
            Console.WriteLine("1. 코트");
            Console.WriteLine("2. 싱크대");
            Console.WriteLine("3. 커피메이커");
            Console.WriteLine("4. 쓰레기통");
            Console.WriteLine("5. 아이스박스");
            Console.WriteLine("6. 전화기");
            Console.WriteLine("=======================");
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
                //코트
                case "1":
                    Console.WriteLine("의자에 걸려있던 실험복을 조사 했지만");
                    Console.WriteLine("실험복에 특별한 건 없었다.");
                    Console.WriteLine("다만 실험복의 신분증에는 R.Venderboom 이라고 써있었다.");
                    break;

                //싱크대
                case "2":
                    //전기실에서 찾은 렌치로 고칠수 있다
                    //그러면 물이 나온다.
                    Console.WriteLine("물이 나오지 않습니다.");
                    Console.WriteLine("세면대의 아래 벨브를 고치면 나올 것 같습니다.");
                    break;

                // 커피 메이커
                case "3":
                    // 전원을 복구해야한다(전기실)
                    // 휴지통에서 커피필터 아이템 구하기
                    //물탱크에 물 체우기
                    // 만들어진 커피는 실험에 사용
                    Console.WriteLine("전기가 들어오지 않아 작동하지 않는 것 같습니다.");
                    break;

                //쓰레기통 
                case "4":
                    // 커피 필터 가 새것과 사용한것이 뒤엉켜 있다.
                    Console.WriteLine("쓰레기통에는 날벌레가 날아다닙니다.");
                    Console.WriteLine("그 안쪽으로 커피 필터들이 새 것과 사용한 것이 뒤엉켜 있습니다.");
                    Console.WriteLine("커피 필터를 얻었습니다.");
                    break;

                //아이스박스
                case "5":
                    // 코드는 cold (실험실에서 힌트 입수)(아이템말고 코드입력으로)
                    // 얼음 입수
                    Console.WriteLine("아이스박스로 보이는 것은 잠겨 있습니다.");
                    Console.WriteLine("비밀 번호를 입력하는 곳이 있습니다.");
                    Console.Write("코드 입력 :(대문자입력)");
                    string input2 = Console.ReadLine();
                    if (input2 == "COLD")
                    {
                        Console.WriteLine("안쪽에는 얼음이 들어있습니다.");
                        Console.WriteLine("얼음을 얻었습니다");
                    }
                    else
                    {
                        Console.WriteLine("틀린것 같다.");
                        Console.WriteLine("열리지 않는다.");
                    }

                    break;

                //전화기
                case "6":
                    // 전원 복원시 사용가능
                    // 사무실의 번호로 전화 가능
                    // 그때 3141 코드 주어짐(사무실 컴퓨터에 사용)
                    Console.WriteLine("전원이 들어오지 않아서일까");
                    Console.WriteLine("전화기는 반응이 없습니다.");
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
