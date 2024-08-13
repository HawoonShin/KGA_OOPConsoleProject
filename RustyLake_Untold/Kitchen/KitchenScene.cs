using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Kitchen
{
    // 부엌


    internal class KitchenScene : Scene
    {
        // 복도와 연결
        private string input;

        public KitchenScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("부엌에는 커피메이커와 작은 싱크대가 있습니다.");
            Console.WriteLine("옆의 쓰레기통에는 파리가 윙윙 거립니다.");
            Thread.Sleep(3000);
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("무엇을 하시겠습니까.");
            Console.WriteLine("1. 조사한다");
            Console.WriteLine("2. 복도로 돌아간다");
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
                case "1":
                    game.ChangeScene(SceneType.KitchenFind); break;
                case "2":
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
