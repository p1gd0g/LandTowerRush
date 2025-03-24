using UnityCommunity.UnitySingleton;
using UnityEngine;

public class MapManager : MonoSingleton<MapManager>
{
    public LandBase LandBaseTemplate;

    const int MapWidth = 20;
    const int MapHeight = 10;

    private Vector3 lastMousePosition; // 上一次鼠标位置
    public float dragSpeed = 0.1f;     // 拖拽速度

    public Transform target;

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

    private void Update()
    {
        HandleDrag();
    }

    private void HandleDrag()
    {
        if (Input.GetMouseButtonDown(0)) // 鼠标左键按下
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0)) // 鼠标左键拖拽
        {
            Vector3 delta = Input.mousePosition - lastMousePosition; // 计算鼠标移动的差值
            Vector3 dragDirection = new Vector3(-delta.x, -delta.y) * dragSpeed; // 转换为拖拽方向
            target.position += dragDirection; // 移动场景或摄像机
            lastMousePosition = Input.mousePosition; // 更新鼠标位置
        }
    }

    protected override void OnInitialized()
    {
        InitMap();
    }
}