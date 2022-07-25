using UnityEngine;
using System.Collections;
using TMPro;

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

        [Header("�u�]�ƶq")]
        public TextMeshProUGUI textMarbleCount;

        private bool canShootMarble = true;

        private Camera cameraMouse;

        private Transform traMouse;

        public Animator ani;
        
        #endregion

        #region �ƥ�

       



        private void Update()
        {
            ShootMarble();
            TurnCharactor();
        }

        // Awake �b Start ���e����@��
        private void Awake()
        {
            ani = GetComponent<Animator>();


            textMarbleCount.text = "x" + canshootMarbleTotal;

            cameraMouse = GameObject.Find("�ഫ�ƹ������Y").GetComponent<Camera>();

            //traMouse = GameObject.Find("�y���ഫ���骫��").GetComponent<transform>();
            traMouse = GameObject.Find("�y���ഫ����骫��").transform;


        }
        #endregion




        #region ��k
        /// <summary>
        /// ���ਤ��B�����⭱�V�ƹ�����m
        /// </summary>
        private void TurnCharactor()
        {
            // 1.�ƹ��y��
            Vector3 posMouse = Input.mousePosition;
            print("<color=yellow>�ƹ��y��:" + posMouse + "</color>");
            // ����v���� Y �b�@��
            posMouse.z = 25;
            // 2.�ƹ��y���ର�@�ɮy��
            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);
            // �N�ഫ�����@�ɮy��
            pos.y = 0.5f;
            // 3.�v�ɮy�е����骫��
            traMouse.position = pos;
        }


        private IEnumerator SpwanMarble()
        {
            for (int i = 0; i < canshootMarbleTotal; i++)
            {
                int total = canshootMarbleTotal;


                ani.SetTrigger(parAttack);
                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�]) ;
                // Quaternion.identity �s�ר�
                GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
                //�Ȧs�u�] ���o���餸�� �K�[���O(����.�e�� * �t��)
                // transform.forward ���⪺�e��
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                total--;
                if (total > 0) textMarbleCount.text = "X" + total;
                else if (total == 0) textMarbleCount.text = "";
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
            // �p�G ����o�g�u�] �N���X
            if (!canShootMarble) return;

            // ��} �ƹ����� �ͦ��õo�g�u�]
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }    
            // ��} �ƹ����� ���ýb�Y �ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // ����o�g�u�]
                canShootMarble = false;

                // print("��}����!");
                arrow.SetActive(false);
                StartCoroutine(SpwanMarble());

               
            }
        }
    }

    

    
}