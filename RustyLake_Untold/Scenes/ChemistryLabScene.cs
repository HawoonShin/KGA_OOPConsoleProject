using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 화학 실험실
    
    //실험에 대한 힌트 = cold라는 글자로 부엌의 아이스박스 오픈가능

    //실험으로 만들어진 '손' 아이템으로 사무실 문 오픈가능
    //(사무실에 지문인식기에 사용)
    
    //실험 내용 아이템4개를 모아오고 가열할 경우 손 생성
    //물 (부엌에서)
    // 커피(부엌에서)
    // 산성액(전기실)
    // 얼음(아이스박스:부엌)

    public class ChemistryLabScene : Scene
    {
        private string input;

        public ChemistryLabScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("화학 연구실은 텅 비어있습니다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("다른 방으로 이동하시겠습니까?");
            Console.WriteLine("1. 복도");
            Console.Write("선택 :");
        }
        public override void Input() 
        {
            input = Console.ReadLine();
        }
        public override void Update() 
        {
            switch(input)
            {
                case "1":
                    game.ChangeScene(SceneType.Hallway);break;
            }
        }
        public override void Exit() { }
    }
}
