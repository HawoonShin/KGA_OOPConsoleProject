using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.HiddenRoom
{
    // 숨겨진 방
    internal class HiddenRoomScene : Scene
    {
        // 침실과 연결

        private string input;
        Inventory inventory;
        Item Item;

        public HiddenRoomScene(Game game) : base(game)
        {

        }


        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 먼지 쌓인 환풍구를 지나오니 숨겨진 방으로 나왔다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 기분 나쁘게 돌아가는 기계가 방에 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("무엇을 하시겠습니까.");
            Console.WriteLine("========================");
            Console.WriteLine("1. 조사한다");
            Console.WriteLine("2. 침실로 돌아간다");
            if (game.inventory.ItemCheck("버튼") == true)
            {
            Console.WriteLine("3. 복도로 돌아간다");
 
            }
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
                    Console.WriteLine(" 당신은 방을 둘러보기로 결정했습니다..");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.HiddenRoomFind);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(" 침실로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Bedroom);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(" 당신은 복도로 돌아갑니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Hallway);
                    break;
            }
        }
        public override void Exit() { }
    }
}
