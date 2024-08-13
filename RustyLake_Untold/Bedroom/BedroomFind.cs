using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Bedroom
{
    internal class BedroomFind : Scene
    {
        //protected Game game;
        private string input;

        public BedroomFind(Game game) : base(game)
        {
            //this.game = game;
        }

        // 정적함수?
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 눈 앞에 침실이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("눈앞에는 침대와 문, 수납형 옷장이 보입니다.");
            Thread.Sleep(2000);
            Console.WriteLine("벽에는 환풍구가 있고 cctv가 돌아갑니다.");
            Thread.Sleep(2000);
            Console.WriteLine("바닥에는 러그가 놓여있고 그 외에는 특별한 것은 보이지 않습니다 ");
            Thread.Sleep(3000); //잠시 글씨를 멈추게 한다
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("1. 침대");
            Console.WriteLine("2. 문");
            Console.WriteLine("3. 옷장");
            Console.WriteLine("4. 환풍구");
            Console.WriteLine("5. CCTV");
            Console.WriteLine("6. 러그");
            Console.WriteLine("==============================");
            Console.WriteLine("0. 인벤토리");
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
                    Console.WriteLine("힌트1을 찾았다!");
                    Console.WriteLine("(아이템은 이벤토리에서 확인 가능합니다.)");
                    break;
                //문
                case "2":
                    //if 열쇠가 있을 경우
                    // 열림
                    // 없을 경우
                    Console.WriteLine("열쇠로 열리는 문같다.");
                    Console.WriteLine("열쇠를 찾아보자.");
                    break;
                case "3":
                    game.ChangeScene(SceneType.BedroomDresser);
                    break;
                //환풍구
                case "4":
                    //드라이버 소지시 오픈가능
                    //안쪽은 미로
                    Console.WriteLine("환풍구는 사람이 들어갈 정도로 입구가 커 보입니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("하지만 지금은 할 수 있는게 없습니다.");
                    Thread.Sleep(1000);
                    break;
                // 카메라 
                case "5": 
                    Console.WriteLine("cctv는 조용히 천장에 매달려 있습니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("어쩐지 기분나쁜 시선이 느껴지는 것 같습니다.");
                    Thread.Sleep(1000);
                    Console.WriteLine("그 외 특별한 점은 없는 것 같습니다.");
                    Thread.Sleep(1000);
                    break;
                //러그
                case "6":
                    //if손전등이 있을 경우 힌트제공
                    //없을 경우 
                    Console.WriteLine("밑 쪽에 공간을 발견합니다!");
                    Thread.Sleep(1000);
                    Console.WriteLine("하지만 너무 어두워서 무언가 필요할 것 같습니다.");
                    Thread.Sleep(1000);
                    break;
                case "0":
                    break;
            }
        }
        public override void Exit() { }
    }
}
