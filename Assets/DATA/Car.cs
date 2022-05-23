using UnityEngine;

public class Car : MonoBehaviour
{
    //重量
    [Tooltip("汽車的重量，重量是噸"), Header("汽車的重量"), Range(1, 60)]
    public int weight = 3;
    //高度
    [Tooltip("汽車的高度，高度是公尺"), Header("汽車的高度"), Range(1, 200)]
    public float height = 3.5f;
    //品牌
    [Tooltip("汽車的品牌種類"), Header("汽車的品牌")]
    public string brand = "奧迪" ;
    //是否有天窗
    [Tooltip("汽車是否有天窗"), Header("天窗")]
    public bool hasSkywindow = true;
}
