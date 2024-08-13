using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 부엌
    internal class KitchenScene : Scene
    {
        // 복도와 연결
        private string input;

        public KitchenScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("부엌에는 커피메이커와 작은 싱크대가 있습니다.");
            Console.WriteLine("옆의 쓰레기통에는 파리가 윙윙 거립니다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("일단 다른 방으로 이동합니다.");
            Console.WriteLine("1. 복도");
            Console.Write("선택 :");
        }
        public override void Input() 
        {
            input = Console.ReadLine();
        }
        public override void Update() { }
        public override void Exit() { }
    }
}
