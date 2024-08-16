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

       
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 당신은 부엌에 들어왔습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 약간은 삭막하지만 여느 부엌과 다를게 없어보입니다.");
            Thread.Sleep(3000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("무엇을 하시겠습니까.");
            Console.WriteLine("========================");
            Console.WriteLine("1. 조사한다");
            Console.WriteLine("2. 복도로 돌아간다");
            Console.WriteLine("========================");
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
                    Console.Clear();
                    Console.WriteLine(" 당신은 부엌을 둘러보기로 결정했습니다..");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.KitchenFind); break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(" 당신은 복도로 돌아갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
