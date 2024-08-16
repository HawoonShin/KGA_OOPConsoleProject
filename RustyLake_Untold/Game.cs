using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustyLake_Untold.Scenes;
using RustyLake_Untold.Bedroom;
using RustyLake_Untold.Kitchen;
using RustyLake_Untold.ChemistryLab;
using RustyLake_Untold.ElectricalRoom;
using RustyLake_Untold.Office;
using RustyLake_Untold.HiddenRoom;


namespace RustyLake_Untold
{
    //프로그램 파일과 동일하게 기초 틀은 교수님의 코드를 사용한다.
    public class Game
    {
        private bool isRunning;

        // 인스턴스 생성!
        //public List<Inventory> inventory = new List<Inventory>();
        public Inventory inventory = new Inventory();
        // 아이템 인스턴스 생성?
        // public Item Item { get; set; }



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
        public void Over()
        {
            isRunning = false;
        }

        // 게임 시작
        private void Start()
        {
            //게임을 실행시킨다
            isRunning = true;

            // 구현한 장면 추가
            scenes = new Scene[(int)SceneType.Size];
            //scenes[(int)SceneType.이동장소] = new 이동장소Scene(this);
            //scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Title] = new TitleScene(this);

            scenes[(int)SceneType.Bedroom] = new BedroomScene(this);
            scenes[(int)SceneType.BedroomFind] = new BedroomFind(this);
            scenes[(int)SceneType.BedroomDresser] = new BedroomDresser(this);

            scenes[(int)SceneType.Hallway] = new HallwayScene(this);

            scenes[(int)SceneType.Kitchen] = new KitchenScene(this);
            scenes[(int)SceneType.KitchenFind] = new KitchenFind(this);

            scenes[(int)SceneType.ChemistryLab] = new ChemistryLabScene(this);
            scenes[(int)SceneType.ChemistryLabFind] = new ChemistryLabFind(this);

            scenes[(int)SceneType.ElectricalRoom] = new ElectricalRoomScene(this);
            scenes[(int)SceneType.ElectricalRoomFind] = new ElectricalRoomFind(this);


            scenes[(int)SceneType.Office] = new OfficeScene(this);
            scenes[(int)SceneType.OfficeFind] = new OfficeFind(this);
            scenes[(int)SceneType.OfficeComputer] = new OfficeComputer(this);


            scenes[(int)SceneType.HiddenRoom] = new HiddenRoomScene(this);
            scenes[(int)SceneType.HiddenRoomFind] = new HiddenRoomFind(this);

            //scenes[(int)SceneType.Inventory] = new InventoryScene(this);
            scenes[(int)SceneType.Ending] = new EndingScene(this);

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
