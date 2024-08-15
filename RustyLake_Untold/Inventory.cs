using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RustyLake_Untold
{
    public class Inventory
    {
        // 아이템 추가 함수
        public List<Item> inventory = new List<Item>();


        public void Add(Item item)
        {
          inventory.Add(item);
        }

        // 아이템 제거 함수
        public void Remove(Item item)
        {
            inventory.Remove(item);
        }

        // 아이템 확인 함수
        public void ItemCheck(Item item)
        {
        }
    }
}
