using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustyLake_Untold;

namespace RustyLake_Untold.Scenes
{
    
    // abstract 여부때문에 오류났었다.
    //다른 곳에서 Scene를 사용할 수 없었다?
    // 원래 intercation 으로 되어있었다?
    public abstract class Scene
    {
        protected Game game;

        public Scene(Game game)
        {
            this.game = game;
        }

        // 정적함수?
        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();
    }
}
