using UnityCommunity.UnitySingleton;
using UnityEngine;

public class MapManager : MonoSingleton<MapManager>
{
    public LandBase LandBaseTemplate;

    const int MapWidth = 20;
    const int MapHeight = 10;

    public void InitMap()
    {
        Debug.Log("InitMap");

        for (int i = 0; i < MapWidth; i++)
        {
            for (int j = 0; j < MapHeight; j++)
            {
                LandBase landBase = Instantiate(LandBaseTemplate, GameManager.Instance.layer0);
                landBase.name = $"LandBase_{i}_{j}";
                landBase.transform.localPosition = new Vector3((i - MapWidth / 2) * 10, (j - MapHeight / 2) * 10);
            }
        }
    }


    protected override void OnInitialized()
    {
        InitMap();
    }

}