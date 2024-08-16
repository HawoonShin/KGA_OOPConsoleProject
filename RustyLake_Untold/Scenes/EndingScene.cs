namespace RustyLake_Untold.Scenes
{
    // 엔딩 
    internal class EndingScene : Scene
    {
        //엔딩 화면 연출

        //엔딩 조건이 많지만 일단은 기계에 들어가면
        //엔딩으로 취급

        //추후에....조건....추가....할수...있겠...지?\
        private string input;

        public EndingScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 기계장치는 밝게 빛을 내기 시작합니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 곧이어 기계의 문이 쾅소리와 함께 닫히고");
            Thread.Sleep(2000);
            Console.WriteLine(" 웅웅거리는 소리와 함께 흔들리기 시작합니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 웅웅거림이 심화되다 결국 기계안에 눈이 멀정도로 밝은 빛이 쏟아집니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 그 뒤 점점 잠잠해지기 시작하더니 당신의 발 밑에 \"검은큐브\"를 발견합니다.");
            Thread.Sleep(3000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("당신은 검은 큐브를 집어 듭니다.");
            Thread.Sleep(2000);
            Console.WriteLine("큐브는 당신의 생각보다 가볍습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("그리고...매끄럽고 시원한 느낌입니다.");
            Thread.Sleep(2000);
            Console.WriteLine("그렇게 큐브를 들여다 보던 당신은 무언가 발견합니다.");
            Thread.Sleep(2000);
            Console.WriteLine("자세히 들여다 봅니다.");
            Thread.Sleep(2000);
            Console.WriteLine("그곳에는 침대와 사람이 자고있는 것이 보입니다");
            Thread.Sleep(2000);
            Console.WriteLine("그리고 그 사람은...당신입니다..!");
            Thread.Sleep(2000);
            Console.WriteLine("당신은 마지막임을 직감합니다.");
            Thread.Sleep(2000);
            Console.WriteLine("무언가를 말해야 할것 같습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 입력 : (wake up)");
        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Update()
        {
            if (input == "wake up")
            {
                Console.WriteLine();
                Console.WriteLine("당신은 그 말과 함께 큐브에 빨려들어감을 느낌니다.");
                Thread.Sleep(2000);
                Console.WriteLine("그리고 점차 잠에 빠져 듭니다.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Ending...");
                Thread.Sleep(2000);
            }
            game.Over(); //게임 오버
        }
        public override void Exit()
        {
        }
    }
}
