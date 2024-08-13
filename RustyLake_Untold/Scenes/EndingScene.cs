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
        public override void Update() { }
        public override void Exit() { }
    }
}
