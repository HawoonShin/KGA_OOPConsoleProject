using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 복도
    internal class HallwayScene : Scene
    {
        //각 종 방들을 연결하는 곳
        // 침실
        // 부엌
        // 화학 실험실
        // 전기실
        // 사무실

        private string input;
        

        public HallwayScene(Game game) : base(game)
        {
           
        }

        // 정적함수?
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("어둡고 긴 '복도'가 당신의 눈앞에 나타났다.");
            Thread.Sleep(2000);

        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("방은 여러 곳과 연결 된거 같다.");
            Console.WriteLine("어디로 이동하시겠습니까?");
            Console.WriteLine("============================");
            Console.WriteLine("1. 침실");
            Console.WriteLine("2. 부엌");
            Console.WriteLine("3. 화학 실험실");
            Console.WriteLine("4. 전기실");
            Console.WriteLine("5. 사무실");
            Console.WriteLine("============================");
            Console.Write("선택 : ");
            
        }
        public override void Input()
        {
            input = Console.ReadLine();
        }
        public override void Update() 
        {
            switch (input) 
            {
                case "1":
                    game.ChangeScene(SceneType.Bedroom);
                    break;
                case "2": 
                    game.ChangeScene(SceneType.Kitchen);
                    break;
                case "3": 
                    game.ChangeScene(SceneType.ChemistryLab);
                    break;
                case "4": 
                    game.ChangeScene(SceneType.ElectricalRoom);
                    break;
                case "5": 
                    game.ChangeScene(SceneType.Office);
                    break;
            }
        }
        public override void Exit()
        { }

    }
}
