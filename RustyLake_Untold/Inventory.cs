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
        public bool ItemCheck(string findItemName)
        {
            //반환할 bool타입 변수
            // 처음에는 false로 두고 못찾았을때 그대로 반환하면 됨
            bool isFinded = false;

            //리스트 내부 순회
            foreach(Item i in inventory)
            {
                if(i.name == findItemName)
                {
                    isFinded = true;
                    break;
                }
            }

            //bool타입 변수의 값을 그대로 넘겨줌
            // 확인의 참거짓을 판단하는 함수로 
            return isFinded;
        }
    }
}
