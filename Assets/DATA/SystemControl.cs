using UnityEngine;
using System.Collections;

namespace GENEX
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
public class SystemControl : MonoBehaviour
    {
        #region ���
        [Tooltip("�b�Y"), Header("�b�Y")]
        public GameObject arrow;
        
        [Tooltip("����t��"), Header("����t��"), Range(1, 500)]
        public float speedTurn = 10.5f;
       
        [Tooltip("�u�]�w�s��"), Header("�u�]�w�s��")]
        public GameObject marble;
        
        [Tooltip("�u�]�i�H�o�g���`��"), Header("�`��"), Range(1, 100)]
        public int canshootMarbleTotal = 15;

        [Tooltip("�u�]�ͦ��I"), Header("�u�]�ͦ��I")]
        public Transform traSpawnPoint;

        [Tooltip("�����ѼƦW��"), Header("�����ѼƦW��")]
        public string parAttack = "Ĳ�o����";

        [Tooltip("�u�]�o�g�t��"), Header("�u�]�o�g�t��"), Range(0, 5000)]
        public float speedMarble = 1000;

        [Tooltip("�u�]�o�g���j"), Header("�u�]�o�g���j"), Range(0, 2)]
        public float intervalMarble = 0.5f;


        public Animator ani;
        #endregion

        #region �ƥ�

        private void Update()
        {
            ShootMarble();
        }

        // Awake �b Start ���e����@��
        private void Awake()
        {
            ani = GetComponent<Animator>();
           
        }
        #endregion




        #region ��k
        /// <summary>
        /// ���ਤ��B�����⭱�V�ƹ�����m
        /// </summary>
        private void TurnCharactor()
        {

        }


        private IEnumerator SpwanMarble()
        {
            for (int i = 0; i < canshootMarbleTotal; i++)
            {

                ani.SetTrigger(parAttack);
                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�]) ;
                // Quaternion.identity �s�ר�
                GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
                //�Ȧs�u�] ���o���餸�� �K�[���O(����.�e�� * �t��)
                // transform.forward ���⪺�e��
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                yield return new WaitForSeconds(intervalMarble);
            }

    }


        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion


        private void ShootMarble()
        {
            // ��} �ƹ����� �ͦ��õo�g�u�]
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }    
            // ��} �ƹ����� ���ýb�Y �ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // print("��}����!");
                arrow.SetActive(false);
                StartCoroutine(SpwanMarble());

               
            }
        }
    }

    

    
}