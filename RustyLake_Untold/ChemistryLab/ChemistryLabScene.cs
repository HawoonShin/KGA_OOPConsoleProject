using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.ChemistryLab
{
    // 화학 실험실

    public class ChemistryLabScene : Scene
    {
        private string input;

        public ChemistryLabScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("화학 연구실은 의외로 비어있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("방 중앙의 실험대와 비커,램프만 덩그러니 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 하지만 당신은 어디선가 시선을 느낍니다.");
            Thread.Sleep(2000);
        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("무엇을 하시겠습니까");
            Console.WriteLine("==============================");
            Console.WriteLine("1. 주변을 조사한다.");
            Console.WriteLine("2. 복도로 돌아간다");
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
                case "1":
                    Console.Clear();
                    Console.WriteLine(" 당신은 실험실을 둘러보기로 결정했습니다..");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.ChemistryLabFind); break;
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
