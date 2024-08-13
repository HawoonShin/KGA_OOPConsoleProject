namespace RustyLake_Untold.Scenes
{
    // 침실
    public class BedroomScene : Scene
    {
        //시작화면
        //퍼즐을 풀면 복도로 연결
        // 특수 상황에 따라 히든 룸으로 연결

        //침대에 힌트 1-1
        //서랍 2째칸에 1-2
        //러그 밑 숨겨진 공간에 힌트
        
        //서랍 1째칸에 힌트들로 비밀번호 입력
        // 입력 후 열쇠로 문 열수 있음

        //아래는 비 필수 요소
        // 카메라 
        // 전등 스위치 
        
        //히든룸 조건
        //통풍구를 드라이버 소지시 열수 있다.
        //미로는 생략
        
        //아이템 창 만들때
        //prevScene을 하나 생성해서
        //curscene을 저장해뒀다가 아이템 확인 후 다시 원래 신으로 돌아오는 방식



        private string input;

        public BedroomScene(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" 눈 앞에 침실이 있습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("눈앞에는 침대와 문, 서랍이 보입니다.");
            Thread.Sleep(2000);
            Console.WriteLine("벽에는 환풍구가 있고 cctv가 돌아갑니다.");
            Thread.Sleep(2000);
            Console.WriteLine("바닥에는 러그가 놓여있고 그 외에는 특별한 것은 보이지 않습니다 ");
            Thread.Sleep(3000); //잠시 글씨를 멈추게 한다
        }

        public override void Exit()
        {
            Console.Clear();
            Console.WriteLine("나가는 중입니다...");
            Thread.Sleep(2000);
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("이동 하시겠습니까?");
            Console.WriteLine("1. 문을 열고 나간다");
            Console.Write("선택 :");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.Hallway); break;
                case "2":
                    game.ChangeScene(SceneType.HiddenRoom); break;

            }
        }
    }
}
