using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold.Scenes
{
    // 사무실
    internal class OfficeScene : Scene
    {
        //복도 와 연결

        //책상
        //서랍 
        //책장에 책 넣는 용도(굳이 안해도 될지도)

        //컴퓨터
        // 코드 입력시(3141)
        // 텍스트 파일 오픈 가능, 카메라 기능(히든 룸 존재 알려주는 용도)
        //텍스트 파일은 새로 드립 편지로 책장에 사용가능(보류)
        
        //책장
        // 컴퓨터에서 얻은 정보로 미로 확보 가능(보류)

        //포스터
        // 번호 확인 가능(전화 용도)
        private string input;

        public OfficeScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("사무실은 깨긋하고 흰색 벽지로 이루어져 있다.");
            Console.WriteLine("그리고 방 한가운데에는 컴퓨터 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.Clear() ;
            Console.WriteLine("다시 이전으로 돌아갑니다.");
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
