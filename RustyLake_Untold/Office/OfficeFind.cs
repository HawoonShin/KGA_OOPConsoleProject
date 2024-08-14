using RustyLake_Untold.Scenes;

namespace RustyLake_Untold.Office
{
    internal class OfficeFind : Scene
    {
        private string input;
        public OfficeFind(Game game) : base(game)
        {
            // this.game = game;
        }

        public override void Enter() { }
        public override void Render()
        {
            Console.WriteLine("무엇을 조사하겠습니까");
            Console.WriteLine("==========================");
            Console.WriteLine("1. 책상");
            Console.WriteLine("2. 컴퓨터");
            Console.WriteLine("3. 책장");
            Console.WriteLine("4. 포스터");
            Console.WriteLine("==========================");
            Console.Write("선택 :");
        }
        public override void Input() { }
        public override void Update()
        {
            switch (input)
            {
                //책상
                case "1":
                    //서랍 
                    //책장에 책 넣는 용도(굳이 안해도 될지도)
                    Console.WriteLine("첫번째 서랍은 잠겨 있습니다.");
                    Console.WriteLine("두번재 서랍은 열려있으나 아무것도 들지 않았습니다.");
                    Console.WriteLine("서랍에 큰 의미는 없어보입니다.");
                    break;

                //컴퓨터
                case "2":
                    // 코드 입력시(3141)
                    // 텍스트 파일 오픈 가능, 카메라 기능(히든 룸 존재 알려주는 용도)
                    //텍스트 파일은 새로 드립 편지로 책장에 사용가능(보류)
                    //컴퓨터 존 따로 뺄것.
                    Console.WriteLine("암호를 입력 하십시오.");
                    Console.WriteLine("작업용 암호 메모 : 3141");
                    int.TryParse(Console.ReadLine(), out int password);
                    if (password == 3141)
                    {
                        game.ChangeScene(SceneType.OfficeComputer);
                    }
                    else { Console.WriteLine("암호가 틀렸다고 화면에 출력됩니다."); }
                    break;

                //책장
                case "3":
                    // 컴퓨터에서 얻은 정보로 미로 확보 가능(보류)
                    break;

                    //포스터
                case "4": 
                    // 번호 확인 가능(전화 용도)
                    Console.WriteLine("벽에 포스터가 걸려있습니다.");
                    Console.WriteLine("포스터는 Rusty Lake 라는 휴양지에 대해 쓰여있습니다.");
                    Console.WriteLine("전화 번호도 쓰여 있습니다.");
                    Console.WriteLine("Call : 099174190");
                    break;
            }
        }
        public override void Exit() { }
    }
}
