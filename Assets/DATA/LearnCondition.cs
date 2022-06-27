using UnityEngine;

public class LearnCondition : MonoBehaviour
{

    public bool opendoor;
    public int combo;

    /// <summary>
    /// 條件式(判斷式)
    /// 1.if
    /// 2.switch
    /// </summary>

    private void Start()
    {
        #region if 判斷式
        // if 語法:
        // if (布林值) { 布林值等於 true 會執行 }
        if (true)
        {
            print("我在判斷式 if 內");
        }
        #endregion
    }

    private void Update()
    {
        //如果 openDoor 等於 true 就開門，否則就關門
        //如果
        // if 語法:
        // if(布林值) { 布林值等於 true 會執行 )
        // 否則 
        // else {布林值等於 false 會執行}
        if (opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
// else if () {}
// 無限數量
// 連