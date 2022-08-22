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

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;
        
        

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

    }
}
