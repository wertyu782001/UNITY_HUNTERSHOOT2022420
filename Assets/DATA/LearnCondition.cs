using UnityEngine;

public class LearnCondition : MonoBehaviour
{

    public bool opendoor;
    public int combo;
    public string prop;

    /// <summary>
    /// 條件式(判斷式)
    /// 1.if
    /// 2.switch
    /// </summary>
    /// 
    public enum StatePlayer
    {
        Idle, Walk, Hurt, Run, Attack, Dead
    }

    public StatePlayer statePlayer;


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

        #region combo加成判例
        if (combo < 100)
        {
            print("攻擊力 + 0%");
        }


        if (combo >= 200)
        {
            print("攻擊力 + 20%");
        }


        if (combo >= 100)
        {
            print("攻擊力 + 10%");
        }
        #endregion


        #region 判斷式 switch
        switch (prop)
        {
            case "紅色藥水":
                print("補血");
                break;

            case "紫色藥水":
                print("變勇敢");
                break;

            case "綠色藥水":
                print("加速");
                break;

            default:
                print("無此道具");
                break;
        }
        #endregion

        #region SWITCH

        switch (statePlayer)
        {
            case StatePlayer.Idle:
                print("待機");
                break;
            case StatePlayer.Walk:
                print("走路");

                break;
            case StatePlayer.Hurt:
                print("受傷");
                break;
            case StatePlayer.Run:
                print("跑步");
                break;
            case StatePlayer.Attack:
                print("攻擊");
                break;
            case StatePlayer.Dead:
                print("死亡");
                break;

            default:
                print("沒事");
                break;
        }
        #endregion

    }


}
