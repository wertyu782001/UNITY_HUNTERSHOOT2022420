using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    private void Test()
    {
        print("���o�A�U�w");
    }
    private void PrintColorText()
    {
        print("<color=#96FED1>�C��T��</color>");
        print("<color=#FFC1E0>�C��T��</color>");
        print("<size=12><color=#7D7DFF>�C��T��</color></size>");

    }        

    private void Start()
    {
        Test();
        PrintColorText();
    }


}
