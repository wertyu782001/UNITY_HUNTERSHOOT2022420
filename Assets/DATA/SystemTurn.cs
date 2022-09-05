using UnityEngine;
using UnityEngine.Events;

namespace GENEX
{

    /// <summary>
    /// ╰参:產┪寄恨瞶
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        /// <summary>
        /// 寄
        /// </summary>
        public UnityEvent onTurnEnemy;
        private int countMarbleEat;

        private bool canSpawn = true;
        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;
            canSpawn = false;
            systemSpawn.SpawnRandomEnemy();
            Invoke("PlayerTurn", 1);
        
        }
        /// <summary>
        /// 紆痌计秖患糤
        /// </summary>
        public void MarbleEat()
        {
            countMarbleEat++;
        }

        /// <summary>
        /// 紆痌羆计
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// ┣籔紆痌羆计
        /// </summary>
        private int totalCountEnemyLive;

        /// <summary>
        /// Μ紆痌计秖
        /// </summary>
        private int totalRecycleMarble;

		


		private void Awake() 
        {
            systemControl = GameObject.Find("ガ狶").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("ネΘ┣╰参").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("Μ跋办").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }
        

        /// <summary>
        /// Μ紆痌
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canshootMarbleTotal;

            totalRecycleMarble++;
            print("<color=yellow>紆痌Μ计秖:" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                print("ΜЧ拨传寄");
                onTurnEnemy.Invoke();
            }

        }
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;

            #region 紆痌计秖矪瞶
            systemControl.canshootMarbleTotal += countMarbleEat;
            countMarbleEat = 0;
            #endregion
        }

    }
}
