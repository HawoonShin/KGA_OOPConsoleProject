using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 부엌
    
    //코트
    // 시리즈 스토리 주인공의 신분증이 나온다.
    // 딱히 아이템으론 필요 없다.

    //싱크대
    //전기실에서 찾은 렌치로 고칠수 있다
    //그러면 물이 나온다.

    // 커피 메이커
    // 전원을 복구해야한다(전기실)
    // 휴지통에서 커피필터 아이템 구하기
    //물탱크에 물 체우기
    // 만들어진 커피는 실험에 사용

    //쓰레기통 
    // 커피 필터 가 새것과 사용한것이 뒤엉켜 있다.

    //아이스박스
    // 코드는 cold (실험실에서 힌트 입수)(아이템말고 코드입력으로)
    // 얼음 입수

    //전화기
    // 전원 복원시 사용가능
    // 사무실의 번호로 전화 가능
    // 그때 3141 코드 주어짐(사무실 컴퓨터에 사용)

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
            Thread.Sleep(3000);
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
        public override void Update() 
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Hallway); break;
            }
        }
        public override void Exit() { }
    }
}
