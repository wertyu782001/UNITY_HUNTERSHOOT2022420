using UnityEngine;


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

        public Animator ani;
        #endregion

        #region 事件

        private void Update()
        {
            shootMarble();
        }
        #endregion




        #region 方法
        /// <summary>
        /// 旋轉角色、讓角色面向滑鼠的位置
        /// </summary>
        private void TurnCharactor()
        {

        }

        /// <summary>
        /// 發射彈珠、根據總數發射彈珠物件
        /// </summary>
        private void ShootMarble()
        {

        }


        /// <summary>
        /// 回收彈珠
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion


        private void shootMarble()
        {
            // 放開 滑鼠左鍵 生成並發射彈珠
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                print("放開左鍵!");

                // Object 類別可省略不寫
                // 直接透過 Object 成員名稱使用
                // 生成(彈珠) ;
                Instantiate(marble, traSpawnPoint.position, Quaternion.identity
                    );
            }
        }
    }

    

    
}