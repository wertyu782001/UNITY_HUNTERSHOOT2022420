using UnityEngine;
using System.Collections.Generic;  //��Ƶ��c �M�� List
using System.Linq;                 // �d�߻y��


namespace GENEX
{
    /// <summary>
    /// �ͦ��Ǫ��t��
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {
        #region ���
        // [] �}�C
        // SerializeField �N�p�H������
        [SerializeField, Header("�Ǫ��}�C")]
        private GameObject[] goEnemy;
        [SerializeField, Header("�ͦ���l�ĤG�Ʈy��")]
        private Transform[] traSecondPlace;

        [SerializeField]
        private List<Transform> listSecondPlace = new List<Transform>();
#endregion

        private void Awake()
        {
            SpawnRadomEnemy();
        }
        /// <summary>
        /// �Ǫ��ͦ��t��
        /// </summary>
        private int totalCountEnemyLive;

        #region ��k
        /// <summary>
        /// �ͦ��H���ĤH
        /// </summary>
        private void SpawnRadomEnemy()
        {
            int min = 2;
            int max = traSecondPlace.Length;


            int randomCount = Random.Range(min, max);
            print("�H���Ǫ��ƶq:" + randomCount);

            //�M�� = �}�C.�ର�M��();
            listSecondPlace = traSecondPlace.ToList();

            // �H������
            System.Random random = new System.Random();
            // �M�� = �M�� �� �Ƨ�(�C�ӲM�椺�e => �H���Ƨ�) �ର�M��
            listSecondPlace = listSecondPlace.OrderBy(x => random.Next()).ToList();
        }
        #endregion
    }
}