using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    internal class InventoryScene : Scene
    {
        //아이템 창 만들때
        //prevScene을 하나 생성해서
        //curscene을 저장해뒀다가 아이템 확인 후 다시 원래 신으로 돌아오는 방식
        //
        //protected Game game;
        // 이쪽은 인벤을 확인하는 용도

        public InventoryScene(Game game) : base(game) 
        {
            //this.game = game;
        }

        // 정적함수?
        public override void Enter() { }
        public override void Render() 
        {
            Console.WriteLine("");
            //현재 소지 아이템 확인
            // 뒤로가기
        }
        public override void Input() { }
        public override void Update() { }
        public override void Exit() { }
    }
}
