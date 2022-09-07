using UnityEngine;
using UnityEngine.Events;
using TMPro;

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
        /// <summary>
        /// �h�ƼƦr
        /// </summary>
        private TextMeshProUGUI textFloorCount;
        private int countFloor = 1;

        [SerializeField, Header("��e�h�Ƴ̤j��"), Range(1, 100)]
        private int countFloorMax = 50;
        private bool isFloorCountMax;

        private bool canSpawn = true;
        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;
            if (!isFloorCountMax)
            {
                canSpawn = false;
                systemSpawn.SpawnRandomEnemy();
            }
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
            textFloorCount = GameObject.Find("�h�ƼƦr").GetComponent<TextMeshProUGUI>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }
        [SerializeField, Header("�S�����ʪ���åB����ͦ����ɶ�"), Range(0, 3)]
        private float noMoveObjectAnDelaySpawn = 1;
        

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

                // �p�G�S���ĤH�N���ʵ����åͦ��ĤH�P�u�]
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    Invoke("MoveEndSpawnEnemy", noMoveObjectAnDelaySpawn);
                }
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

            if (countFloor < countFloorMax)
            {
                countFloor++;
                textFloorCount.text = countFloor.ToString();
            }
            if (countFloor == countFloorMax) isFloorCountMax = true;

            if (isFloorCountMax)
            {
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    print("���d�D�Ԧ��\");
                }
            }

            countFloor++;
            textFloorCount.text = countFloor.ToString();
        }

    }
}
