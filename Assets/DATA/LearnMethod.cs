using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Test()
    {
        print("哈囉，沃德");
    }
    private void PrintColorText()
    {
        print("<color=#96FED1>顏色訊息</color>");
        print("<color=#FFC1E0>顏色訊息</color>");
        print("<color=#7D7DFF>顏色訊息</color>");

    }        

    private void Start()
    {
        Test();
        PrintColorText();
    }


}
