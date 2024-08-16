namespace RustyLake_Untold
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 음악 플레이어
            MusicPlayer Bgm = new(@"C:\GIT\consoleProject\KGA_OOPConsoleProject\RustyLake_Untold\Rusty Lake Theme.mp3");
            Bgm.Volume = 100;
            Bgm.Loop = true;
            Bgm.Play();
            ProgramExit(ConsoleKey.P, ConsoleKey.Escape);

            // 기초 게임이 돌아가는 구성은 교수님이 짜신 코드와 동일하게 제작
            Game game = new Game();
            game.Run();
        }
        static void ProgramExit(params ConsoleKey[] keys)
        {
            bool isRunning = true;
            ConsoleKeyInfo inputkey;

            foreach (var key in keys)
            {
                Console.Write($"[{key}] ");
            }
            Console.WriteLine("키를 누르면 종료");

            while (isRunning)
            {
                inputkey = Console.ReadKey();

                if (Array.Exists(keys, element => element == inputkey.Key))
                {
                    break;
                }
            }
        }
    }
}
