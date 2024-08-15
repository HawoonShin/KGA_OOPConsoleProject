using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    internal class InventoryScene : Inventory
    {
        //아이템 창 만들때
        //prevScene을 하나 생성해서
        //curscene을 저장해뒀다가 아이템 확인 후 다시 원래 신으로 돌아오는 방식
        //
        //protected Game game;
        // 이쪽은 인벤을 확인하는 용도
        

        public InventoryScene(Game game) 
        {
            //this.game = game;
        }

    }
}
