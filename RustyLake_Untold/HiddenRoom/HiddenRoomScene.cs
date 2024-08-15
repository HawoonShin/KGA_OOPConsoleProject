using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.HiddenRoom
{
    // 숨겨진 방
    internal class HiddenRoomScene : Scene
    {
        // 침실과 연결

        private string input;

        public HiddenRoomScene(Game game) : base(game)
        {

        }

       
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("먼지 쌓인 환풍구를 지나오니 숨겨진 방으로 나왔다.");
            Console.WriteLine("기분 나쁘게 돌아가는 기계가 방에 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("조건을 만족하면 엔딩으로 연결됩니다.");
        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Ending);
                    break;
            }
        }
        public override void Exit() { }
    }
}
