namespace RustyLake_Untold.Scenes
{
    // 복도
    internal class HallwayScene : Scene
    {
        //각 종 방들을 연결하는 곳
        // 침실
        // 부엌
        // 화학 실험실
        // 전기실
        // 사무실

        private string input;


        public HallwayScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 어둡고 긴 '복도'가 당신의 눈앞에 나타났습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 방은 여러 곳과 연결 된거 같습니다.");
            Thread.Sleep(2000);

        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("어디로 이동하시겠습니까?");
            Console.WriteLine("============================");
            Console.WriteLine("1. 침실");
            Console.WriteLine("2. 부엌");
            Console.WriteLine("3. 화학 실험실");
            Console.WriteLine("4. 전기실");
            Console.WriteLine("5. 사무실");
            if (game.inventory.ItemCheck("빨간 버튼") == true)
            {
                Console.WriteLine("6. 숨겨진 방");
            }
            Console.WriteLine("============================");
            Console.Write("선택 : ");

        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Update()
        {
            //각 방문에 관한 세부 묘사 일부 필요
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("침실로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Bedroom);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("부엌로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Kitchen);
                    break;
                case "3":
                        Console.Clear();
                        Console.WriteLine("화학 실험실로 이동합니다.");
                        Thread.Sleep(2000);
                        game.ChangeScene(SceneType.ChemistryLab);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("전기실로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.ElectricalRoom);
                    break;
                case "5":
                    if (game.inventory.ItemCheck("팔") == true)
                    {
                    Console.Clear();
                    Console.WriteLine("당신은 갖고있던 팔을 지문인식기에 가져다 댑니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("지문 인식기가 인증되었다는 소리와 함께 문이 열립니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine("사무실로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.Office);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" 사무실은 잠겨 있습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 지문인식으로 여는 문 같습니다.");
                        Thread.Sleep(2000);
                    }
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("숨겨진 방으로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.HiddenRoom);
                    break;
            }
        }
        public override void Exit()
        { }

    }
}
