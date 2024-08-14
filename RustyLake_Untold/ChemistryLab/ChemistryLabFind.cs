using RustyLake_Untold.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.ChemistryLab
{
    internal class ChemistryLabFind : Scene
    {
        protected Game game;
        private string input;

        public ChemistryLabFind(Game game) :base(game)
        {
            //this.game = game;
        }

        // 정적함수?
        public override void Enter() 
        {
            Console.WriteLine("여러가지 화학장비가 늘어진 작업대가 있습니다.");
        }
        public override void Render() 
        { 
            Console.WriteLine("조사할 대상을 선택해 주세요");
            Console.WriteLine("1. 화학 테이블 ");
            Console.WriteLine("2. 화학 테이블 서랍");
            Console.WriteLine("3. 작은 환풍구");
            Console.WriteLine("0. 인벤토리 확인");
            Console.WriteLine("9. 뒤로 돌아가기");

        }
        public override void Input() 
        {
            input = Console.ReadLine();   
        }
        public override void Update()
        {
            //실험으로 만들어진 '손' 아이템으로 사무실 문 오픈가능
            //(사무실에 지문인식기에 사용)

            //실험 내용 아이템4개를 모아오고 가열할 경우 손 생성
            //물 (부엌에서)
            // 커피(부엌에서)
            // 산성액(전기실)
            // 얼음(아이스박스:부엌)
            switch (input)
            {
                case "1":
                    //아이템 4개가 있는게 확인이 되면 
                    //실험이 진행된다.
                    //아닐경우 다음같은 메세지 출력
                    Console.WriteLine("실험 테이블에는 비커와 버너가 있습니다.");
                    Console.WriteLine("이 도구들을 이용하여 실험을 해야할것 같습니다.");
                    break;

                case "2":
                    Console.WriteLine("서랍을 열어보니 실험서가 들어있었습니다.");
                    Console.WriteLine("===================");
                    Console.WriteLine("-필요한것 : 물 / 산성액 / 뜨거운 커피 / 얼음");
                    Console.WriteLine("-주의사항 : 얼음은 항상 \"차가운(COLD)\"상태로 할것!");
                    Console.WriteLine("===================");
                    Console.WriteLine("");
                    break;

                case "3":
                    Console.WriteLine("환풍구를 들여다 보자 환풍구 너머로 눈빛같은 것이 반짝이는 것을 보았습니다.");
                    Console.WriteLine("깜짝 놀란 당신은 뒤로 넘어집니다.");
                    Console.WriteLine("부스럭 거리는 소리에 당신은 다시 확인해보았지만");
                    Console.WriteLine("그곳에는 아무도 없습니다.");
                    break;
            }

        }
        public override void Exit() { }
    }
}
