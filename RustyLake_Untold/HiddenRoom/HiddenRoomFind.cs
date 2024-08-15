using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.HiddenRoom
{
    internal class HiddenRoomFind : Scene
    {
        private string input;
        public HiddenRoomFind(Game game) : base(game)
        {
            // this.game = game;
        }

   
        public override void Enter() { }
        public override void Render()
        {
            Console.WriteLine("기계실을 조사합니다.");
            Console.WriteLine("1. 기계");
            Console.WriteLine("2. 포스터");
            Console.WriteLine("3. 빨간버튼");
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
                    Console.WriteLine("기계에는 입력할 수 있는 패널이 존재합니다.");
                    Console.WriteLine("암호를 입력하세요 : (제작용 ACF)");
                    string password = Console.ReadLine();
                    if(password == "ACF" )
                    {
                        Console.WriteLine("기계가 웅웅 거리는 소리를 내며 작동하기 시작합니다.");
                        game.ChangeScene(SceneType.Ending);
                    }
                    else 
                    {
                        Console.WriteLine("딱히 반응하지 않습니다.");
                    }
                    break;

                //포스터
                case "2":
                    //기계 작동용 힌트
                    Console.WriteLine("포스터를 들춰보니 뒤쪽에 영어가 적혀있습니다.");
                    Console.WriteLine("\"ACF\"");
                    Console.WriteLine("어디에 쓰는 비밀번호 일까요");
                    break;

                //빨간버튼
                case "3":
                    // 복도와 연결되는 문 생성
                    Console.WriteLine("빨간버튼을 누르자 덜컹하는 소리가 들립니다.");
                    Console.WriteLine("방안에 새로운 문이 생겼습니다.");
                    Console.WriteLine("문은 복도와 이어지는것 같습니다.");

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
