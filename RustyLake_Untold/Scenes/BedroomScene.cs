namespace RustyLake_Untold.Scenes
{
    // 침실
    public class BedroomScene : Scene
    {
        //시작화면
        //퍼즐을 풀면 복도로 연결
        // 특수 상황에 따라 히든 룸으로 연결

        private string input;

        public BedroomScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 눈 앞에 침실이 있습니다.");
            Thread.Sleep(2000); //잠시 글씨를 멈추게 한다
        }

        public override void Exit()
        {

        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("눈앞에는 침대와 문, 서랍이 보입니다.");
            Console.WriteLine("벽에는 환풍구가 있고 cctv가 돌아갑니다.");
            Console.WriteLine("바닥에는 러그가 놓여있고 그 외에는 특별한 것은 보이지 않습니다 ");
            Console.WriteLine("이동 하시겠습니까?");
            Console.WriteLine("1. 문을 열고 나간다");
            Console.Write("선택 :");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Hallway); break;
                case "2":
                    game.ChangeScene(SceneType.HiddenRoom); break;

            }
        }
    }
}
