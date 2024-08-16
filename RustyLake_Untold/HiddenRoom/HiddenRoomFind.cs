using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.HiddenRoom
{
    internal class HiddenRoomFind : Scene
    {
        private string input;
        Inventory inventory;
        Item Item;
        public HiddenRoomFind(Game game) : base(game)
        {
            // this.game = game;
        }

   
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine(" 방 한가운데에 거대한 기게가 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 벽에는 빨간 버튼과 액자가 걸려있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 바닥은 알수없는 이야기들이 적힌 종이가 널려있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 사무실에서 본 cctv가 있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("==============================");
            Console.WriteLine("1. 기계");
            Console.WriteLine("2. 액자");
            Console.WriteLine("3. 빨간버튼");
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
                //기계
                case "1":
                    //패널에 ACF입력
                    //조건 만족하고 타면 엔딩
                    Console.Clear();
                    Console.WriteLine("기계에는 입력할 수 있는 패널이 존재합니다.");
                    Console.WriteLine("암호를 입력하세요 : (테스트용 ACF)");
                    string password = Console.ReadLine();
                    if(password == "ACF" )
                    {
                        Console.WriteLine("기계가 웅웅 거리는 소리를 내며 작동하기 시작합니다.");
                        Thread.Sleep(2000);
                        game.ChangeScene(SceneType.Ending);
                    }
                    else 
                    {
                        Console.WriteLine("딱히 반응하지 않습니다.");
                        Thread.Sleep(2000);
                    }
                    break;

                //액자
                case "2":
                    //기계 작동용 힌트
                    Console.Clear();
                    Console.WriteLine("액자를 들춰보니 뒤쪽에 영어가 적혀있습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"ACF\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("어디에 쓰는 비밀번호 일까요");
                    Thread.Sleep(2000);
                    break;

                //빨간버튼
                case "3":
                    // 복도와 연결되는 문 생성
                    Console.Clear();
                    Console.WriteLine("빨간버튼을 누르자 덜컹하는 소리가 들립니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("방안에 새로운 문이 생겼습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("문은 복도와 이어지는것 같습니다.");
                    Thread.Sleep(2000);

                    Item redButton = new Item(this);
                    redButton.id = 13;
                    redButton.name = "빨간 버튼";
                    redButton.description = "왜 내가 버튼을 '갖고' 있는거죠?";
                    game.inventory.Add(redButton);
                    break;
            }
        }
        public override void Exit() { }
    }
}
