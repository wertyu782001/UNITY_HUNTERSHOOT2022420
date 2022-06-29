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
        #endregion

        #region 事件
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
    }

}