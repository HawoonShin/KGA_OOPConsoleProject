﻿namespace RustyLake_Untold.Scenes
{
    // 숨겨진 방
    internal class HiddenRoomScene : Scene
    {
        // 침실과 연결

        //기계
        //패널에 ACF입력
        //조건 만족하고 타면 엔딩

        //포스터
        //기계 작동용 힌트

        //빨간버튼
        // 복도와 연결되는 문 생성(보류)
        private string input;

        public HiddenRoomScene(Game game) : base(game)
        {

        }

        // 정적함수?
        public override void Enter() 
        {
            Console.Clear();
            Console.WriteLine("먼지 쌓인 환풍구를 지나오니 숨겨진 방으로 나왔다.");
            Console.WriteLine("기분 나쁘게 돌아가는 기계가 방에 놓여있다.");
            Thread.Sleep(2000);
        }
        public override void Render() 
        {
            Console.Clear();
            Console.WriteLine("조건을 만족하면 엔딩으로 연결됩니다.");
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
                    game.ChangeScene(SceneType.Ending);
                    break;
            }
        }
        public override void Exit() { }
    }
}
