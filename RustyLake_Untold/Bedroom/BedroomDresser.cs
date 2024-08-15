﻿using RustyLake_Untold.Scenes;


namespace RustyLake_Untold.Bedroom
{
    public class BedroomDresser : Scene
    {
        private string input;

        Inventory inventory;
        Item Item;

        public BedroomDresser(Game game) : base(game)
        {
            //this.game = game;

            



        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 작고 소박한 나무로 만든 옷장입니다.");
            Thread.Sleep(1000);
            Console.WriteLine(" 옷장에는 3개의 서랍장이 있습니다.");
            Thread.Sleep(1000);
        }
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine(" 어느 서랍장을 조사하겠습니까?");
            Console.WriteLine(" 1번째 서랍장");
            Console.WriteLine(" 2번째 서랍장");
            Console.WriteLine(" 3번째 서랍장");
            Console.WriteLine("============================");
            Console.WriteLine(" 0. 인벤토리 확인");
            Console.WriteLine(" 9. 조사로 돌아간다");
            Console.WriteLine("============================");

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
                //서랍 1째칸에 힌트들로 비밀번호 입력
                case "1":
                    Console.WriteLine("서랍장은 비밀번호로 잠겨 있습니다.");
                    Console.Write("비밀번호 입력 :(제작용 임시비번 0000)");
                    int.TryParse(Console.ReadLine(), out int input2);
                    if (input2 == 0000)
                    {
                        Item bedroomKey = new Item(this);
                        bedroomKey.id = 1;
                        bedroomKey.name = "침실 열쇠";
                        bedroomKey.description = "침실문을 열수 있는 작은 열쇠";

                        game.inventory.Add(bedroomKey);
                        Console.WriteLine("열쇠를 발견하였습니다.");
                    }
                    else
                    {
                        Console.WriteLine("옷장 조사로 돌아갑니다.");
                    }
                    break;

                //서랍 2째칸에 1-2
                case "2":
                    //힌트 아이템 추가할것
                    Console.WriteLine("힌트를 발견하였습니다.");
                    break;

                //서랍 3째칸에 손전등
                case "3":
                    //손전등 아이템에 추가할 것

                    Item fleshright = new Item(this);
                    fleshright.id = 2;
                    fleshright.name = "손전등";
                    fleshright.name = "어두운 곳을 밝힐 수 있는 손전등이다.";

                    game.inventory.Add(fleshright);

                    Console.WriteLine("손전등을 발견하였습니다.");
                    break;
                case "0":
                    game.ChangeScene(SceneType.Inventory);
                    break;
                case "9":
                    game.ChangeScene(SceneType.BedroomFind);
                    break;

            }
        }
        public override void Exit() { }
    }
}
