using UnityEngine;
using System.Collections.Generic;  //資料結構 清單 List
using System.Linq;                 // 查詢語言


namespace GENEX
{
    /// <summary>
    /// 生成怪物系統
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {
        #region 資料
        // [] 陣列
        // SerializeField 將私人欄位顯示
        [SerializeField, Header("怪物陣列")]
        private GameObject[] goEnemy;
        [SerializeField, Header("生成格子第二排座標")]
        private Transform[] traSecondPlace;

        [SerializeField]
        private List<Transform> listSecondPlace = new List<Transform>();
#endregion

        private void Awake()
        {
            SpawnRandomEnemy();
        }
        /// <summary>
        /// 怪物生成系統
        /// </summary>
        public int totalCountEnemyLive;

        #region 方法
        /// <summary>
        /// 生成隨機敵人
        /// </summary>
       public void SpawnRandomEnemy()
        {
            int min = 2;
            int max = traSecondPlace.Length;


            int randomCount = Random.Range(min, max);
            print("隨機怪物數量:" + randomCount);

            //清單 = 陣列.轉為清單();
            listSecondPlace = traSecondPlace.ToList();

            // 隨機物件
            System.Random random = new System.Random();
            // 清單 = 清單 的 排序(每個清單內容 => 隨機排序) 轉為清單
            listSecondPlace = listSecondPlace.OrderBy(x => random.Next()).ToList();
        }
        #endregion
    }
}