using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 화학 실험실
    public class ChemistryLabScene : Scene
    {
        private string input;

        public ChemistryLabScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("화학 연구실은 텅 비어있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("다른 방으로 이동하시겠습니까?");
            Console.WriteLine("1. 복도");
            Console.Write("선택 :");
        }
        public override void Input() 
        {
            input = Console.ReadLine();
        }
        public override void Update() 
        {
            switch(input)
            {
                case "1":
                    game.ChangeScene(SceneType.Hallway);break;
            }
        }
        public override void Exit() { }
    }
}
