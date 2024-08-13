namespace RustyLake_Untold
{
    // 여기 클래스 안에다 넣어둬서 인식 못했다. 
    // 배열을 다른곳에서 쓸때는 클래스 밖에 쓰자.

    //다른 배열들은 당장에 필요하진 않고 일단은 장면별(맵별) 내용들 추가
    public enum SceneType
    {
        Title, Select,
        Bedroom, BedroomFind,
        Hallway, Kitchen,Inventory,
        ChemistryLab, ElectricalRoom, Office, HiddenRoom,Ending,
            Size //이거 넣으면 앞쪽에 size 오류 해결되나?
    }
    //엔딩씬의 추가에 대해서 고려해볼것.

}
