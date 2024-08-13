using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Scenes
{
    // 타이틀 화면
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game) 
        {
        }


        public override void Enter()
        {
            // 구현이 필요한가?
        }

        public override void Exit()
        {
            
        }

        public override void Input() 
        {
            Console.ReadKey();
        }

        // 타이틀 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("*                             *");
            Console.WriteLine("*     Rusty Lake : Untold     *");
            Console.WriteLine("*                             *");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("   계속하려면 아무키나 누르세요   ");
        }

        // 입력시 선택 씬으로 이동
        public override void Update()
        {
            game.ChangeScene(SceneType.Bedroom);
        }
    }
}
