using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 엔딩 
    internal class EndingScene : Scene
    {
        //엔딩 화면 연출

        //엔딩 조건이 많지만 일단은 기계에 들어가면
        //엔딩으로 취급
        
        //추후에....조건....추가....할수...있겠...지?

        public EndingScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("와 엔딩!");
        }
        public override void Render() { }
        public override void Input() { }
        public override void Update() 
        { 
            
        }
        public override void Exit() 
        {
            game.Over(); //게임 오버
        }
    }
}
