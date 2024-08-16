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
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" 당신은 어둠 속에서 한없이 떨어지는 느낌을 받습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 당신은 당신이 누구인지, 어디인지 알수없습니다.");
            Thread.Sleep(2000);
            Console.WriteLine(" 무엇이든 기억하려고 노력하던 그때 어떤 목소리가 들립니다.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" It's time to wake up!");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.WriteLine(" 그 목소리에 당신은 눈을 뜹니다...");
            Thread.Sleep(2000);
        }

        public override void Input() 
        {
            Console.ReadKey();
        }

        // 타이틀 출력
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine(" *******************************");
            Console.WriteLine(" *                             *");
            Console.WriteLine(" *     Rusty Lake : Untold     *");
            Console.WriteLine(" *                             *");
            Console.WriteLine(" *******************************");
            Console.WriteLine();
            Console.WriteLine("   계속하려면 아무키나 누르세요. . .   ");
        }

        // 입력시 선택 씬으로 이동
        public override void Update()
        {
            game.ChangeScene(SceneType.Bedroom);
        }
    }
}
