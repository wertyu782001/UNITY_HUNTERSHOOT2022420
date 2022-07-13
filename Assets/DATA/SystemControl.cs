using UnityEngine;


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

        public Animator ani;
        #endregion

        #region �ƥ�

        private void Update()
        {
            shootMarble();
        }
        #endregion




        #region ��k
        /// <summary>
        /// ���ਤ��B�����⭱�V�ƹ�����m
        /// </summary>
        private void TurnCharactor()
        {

        }

        /// <summary>
        /// �o�g�u�]�B�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {

        }


        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }

        #endregion


        private void shootMarble()
        {
            // ��} �ƹ����� �ͦ��õo�g�u�]
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                print("��}����!");

                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�]) ;
                Instantiate(marble, traSpawnPoint.position, Quaternion.identity
                    );
            }
        }
    }

    

    
}