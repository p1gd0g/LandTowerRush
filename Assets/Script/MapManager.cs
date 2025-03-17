using UnityCommunity.UnitySingleton;
using UnityEngine;

public class MapManager : MonoSingleton<MapManager>
{
    public LandBase LandBaseTemplate;

    public void InitMap()
    {
        Debug.Log("InitMap");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                LandBase landBase = Instantiate(LandBaseTemplate, new Vector3(i, 0, j), Quaternion.identity);
                landBase.name = $"LandBase_{i}_{j}";
            }
        }
    }

}