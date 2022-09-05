using UnityEngine;
using UnityEngine.Events;

namespace GENEX
{

    /// <summary>
    /// �^�X�t��:���a�μĤH�^�X�޲z
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        /// <summary>
        /// �ĤH�^�X
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
        /// �Y��u�]�ƶq���W
        /// </summary>
        public void MarbleEat()
        {
            countMarbleEat++;
        }

        /// <summary>
        /// �u�]�`��
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// �Ǫ��P�i�H�Y���u�]�s���`��
        /// </summary>
        private int totalCountEnemyLive;

        /// <summary>
        /// �^���u�]�ƶq
        /// </summary>
        private int totalRecycleMarble;

		


		private void Awake() 
        {
            systemControl = GameObject.Find("�����L").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }
        

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canshootMarbleTotal;

            totalRecycleMarble++;
            print("<color=yellow>�u�]�^���ƶq:" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();
            }

        }
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;

            #region �u�]�ƶq�B�z
            systemControl.canshootMarbleTotal += countMarbleEat;
            countMarbleEat = 0;
            #endregion
        }

    }
}
