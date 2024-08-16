using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.ChemistryLab
{
    internal class ChemistryLabFind : Scene
    {
        protected Game game;
        private string input;

        public ChemistryLabFind(Game game) : base(game)
        {
            //this.game = game;
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 당신은 실험실을 좀 더 자세히 살펴보기로 했습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 작업대에는 누군가 마셨던거 같은 커피잔과 비커, 램프를 발견합니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 작업대에는 작은 서랍도 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 시선이 느껴지는 환풍구에도 시선이 갑니다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("무엇을 조사하겠습니까?");
            Console.WriteLine("==============================");
            Console.WriteLine("1. 화학 테이블 ");
            Console.WriteLine("2. 화학 테이블 서랍");
            Console.WriteLine("3. 작은 환풍구");
            Console.WriteLine("==============================");
            //Console.WriteLine("0. 인벤토리 확인");
            Console.WriteLine("9. 뒤로 돌아가기");
            Console.WriteLine("==============================");
            Console.Write("선택 :");

        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Update()
        {
            //실험으로 만들어진 '손' 아이템으로 사무실 문 오픈가능
            //(사무실에 지문인식기에 사용)

            //실험 내용 아이템4개를 모아오고 가열할 경우 손 생성
            //물 (부엌에서)
            // 커피(부엌에서)
            // 산성액(전기실)
            // 얼음(아이스박스:부엌)
            switch (input)
            {
                case "1":
                    //아이템 4개가 있는게 확인이 되면 
                    //실험이 진행된다.
                    //아닐경우 다음같은 메세지 출력
                    if (game.inventory.ItemCheck("물") == true &&
                        game.inventory.ItemCheck("커피") == true &&
                        game.inventory.ItemCheck("산성액") == true &&
                        game.inventory.ItemCheck("얼음") == true)
                    {
                        Console.Clear();
                        Console.WriteLine(" 당신은 갖고있던 물, 커피, 산성액, 얼음을");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 실험서에 적혀있는대로 가열을 하기 시작합니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 그것들은 검게 변하기 시작하더니 덩어리 지기 시작합니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 덩어리는 점차 형태를 갖기 시작하더니 팔의 형태로 변합니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 팔을 얻었습니다.");
                        Thread.Sleep(2000);

                        Item arm = new Item(this);
                        arm.id = 5;
                        arm.name = "팔";
                        arm.description = "팔입니다. \n 어딘가에서 지문인식을 본것도 같습니다.";

                        game.inventory.Add(arm);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" 실험 테이블에는 비커와 버너가 있습니다.");
                        Thread.Sleep(2000);
                        Console.WriteLine(" 이 도구들을 이용하여 실험을 해야할것 같습니다.");
                        Thread.Sleep(2000);
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(" 서랍을 열어보니 실험서가 들어있었습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("====================================================");
                    Console.WriteLine("-필요한것 : 물 / 산성액 / 뜨거운 커피 / 얼음");
                    Thread.Sleep(2000);
                    Console.WriteLine("-주의사항 : 얼음은 항상 \"차가운(COLD)\"상태로 할것!");
                    Thread.Sleep(2000);
                    Console.WriteLine("======================================================");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(" 환풍구를 들여다 보자 환풍구 너머로 눈빛같은 것이 반짝이는 것을 보았습니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 깜짝 놀란 당신은 뒤로 넘어집니다.");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 부스럭 거리는 소리에 당신은 다시 확인해보았지만");
                    Thread.Sleep(2000);
                    Console.WriteLine(" 그곳에는 아무도 없습니다.");
                    Thread.Sleep(2000);
                    break;

                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    Console.Clear();
                    Console.WriteLine(" 화학 실험실로 이동합니다.");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.ChemistryLab);
                    break;
            }

        }
        public override void Exit() { }
    }
}
