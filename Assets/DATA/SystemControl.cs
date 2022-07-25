using UnityEngine;
using System.Collections;
using TMPro;

namespace GENEX
{
    /// <summary>
    /// 玩家控制系統
    /// 物件旋轉、發射彈珠
    /// </summary>
public class SystemControl : MonoBehaviour
    {
        #region 資料
        [Tooltip("箭頭"), Header("箭頭")]
        public GameObject arrow;
        
        [Tooltip("旋轉速度"), Header("旋轉速度"), Range(1, 500)]
        public float speedTurn = 10.5f;
       
        [Tooltip("彈珠預製物"), Header("彈珠預製物")]
        public GameObject marble;
        
        [Tooltip("彈珠可以發射的總數"), Header("總數"), Range(1, 100)]
        public int canshootMarbleTotal = 15;

        [Tooltip("彈珠生成點"), Header("彈珠生成點")]
        public Transform traSpawnPoint;

        [Tooltip("攻擊參數名稱"), Header("攻擊參數名稱")]
        public string parAttack = "觸發攻擊";

        [Tooltip("彈珠發射速度"), Header("彈珠發射速度"), Range(0, 5000)]
        public float speedMarble = 1000;

        [Tooltip("彈珠發射間隔"), Header("彈珠發射間隔"), Range(0, 2)]
        public float intervalMarble = 0.5f;

        [Header("彈珠數量")]
        public TextMeshProUGUI textMarbleCount;

        private bool canShootMarble = true;

        private Camera cameraMouse;

        private Transform traMouse;

        public Animator ani;
        
        #endregion

        #region 事件

       



        private void Update()
        {
            ShootMarble();
            TurnCharactor();
        }

        // Awake 在 Start 之前執行一次
        private void Awake()
        {
            ani = GetComponent<Animator>();


            textMarbleCount.text = "x" + canshootMarbleTotal;

            cameraMouse = GameObject.Find("轉換滑鼠用鏡頭").GetComponent<Camera>();

            //traMouse = GameObject.Find("座標轉換實體物件").GetComponent<transform>();
            traMouse = GameObject.Find("座標轉換後實體物件").transform;


        }
        #endregion




        #region 方法
        /// <summary>
        /// 旋轉角色、讓角色面向滑鼠的位置
        /// </summary>
        private void TurnCharactor()
        {
            // 1.滑鼠座標
            Vector3 posMouse = Input.mousePosition;
            print("<color=yellow>滑鼠座標:" + posMouse + "</color>");
            // 跟攝影機的 Y 軸一樣
            posMouse.z = 25;
            // 2.滑鼠座標轉為世界座標
            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);
            // 將轉換完的世界座標
            pos.y = 0.5f;
            // 3.史界座標給實體物件
            traMouse.position = pos;
        }


        private IEnumerator SpwanMarble()
        {
            for (int i = 0; i < canshootMarbleTotal; i++)
            {
                int total = canshootMarbleTotal;


                ani.SetTrigger(parAttack);
                // Object 類別可省略不寫
                // 直接透過 Object 成員名稱使用
                // 生成(彈珠) ;
                // Quaternion.identity 零度角
                GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
                //暫存彈珠 取得剛體元件 添加推力(角色.前方 * 速度)
                // transform.forward 角色的前方
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                total--;
                if (total > 0) textMarbleCount.text = "X" + total;
                else if (total == 0) textMarbleCount.text = "";
                yield return new WaitForSeconds(intervalMarble);
            }

    }


        /// <summary>
        /// 回收彈珠
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion


        private void ShootMarble()
        {
            // 如果 不能發射彈珠 就跳出
            if (!canShootMarble) return;

            // 放開 滑鼠左鍵 生成並發射彈珠
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }    
            // 放開 滑鼠左鍵 隱藏箭頭 生成並發射彈珠
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // 不能發射彈珠
                canShootMarble = false;

                // print("放開左鍵!");
                arrow.SetActive(false);
                StartCoroutine(SpwanMarble());

               
            }
        }
    }

    

    
}