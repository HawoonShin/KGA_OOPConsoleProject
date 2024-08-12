using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RustyLake_Untold
{
    //프로그램 파일과 동일하게 기초 틀은 교수님의 코드를 사용한다.
    internal class Game
    {
        private bool isRunning;

        private Scene[] scenes;
        private Scene curScene;
        public Scene CurScene { get { return curScene; } }

        /* 보류. 내 게임에는 플레이어가 딱히 필요하지 않다.
        private Player player;
        public Player Plyaer { get { return player; } set { player = value; } } */

        // 실제 게임이 돌아가는 부분
        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();   // 선택지, 상황 제시
                Input();    // 입력
                Update();   // 출력
            }
            End();
        }

        // 장면의 전환
        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        //게임오버 출력 (보류) 당장의 게임오버가 필요하지 않는다
        /*public void Over()
        {
            isRunning = false;
        }*/

        // 게임 시작
        private void Start()
        {
            //게임을 실행시킨다
            isRunning = true;

            // 구현한 장면 추가
            scenes = new Scene[(int)SceneType.Size];
            //scenes[(int)SceneType.이동장소] = new 이동장소Scene(this);
            scenes[(int)SceneType.Title] = new TitleScene(this);
            //scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Bedroom] = new BedroomScene(this);

            // 현재 장면의 선택 및 입장? 출현?
            curScene = scenes[(int)SceneType.Title];
            curScene.Enter();
        }

        //끝 = 엔딩?
        private void End()
        {
            curScene.Exit();
        }

        //현 상황의 출력
        private void Render()
        {
            curScene.Render();
        }

        // 입력 상황
        private void Input()
        {
            curScene.Input();
        }

        // 입력에 대한 출력
        private void Update()
        {
            curScene.Update();
        }
    }
}
