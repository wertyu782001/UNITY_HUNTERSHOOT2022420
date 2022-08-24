using UnityEngine;

namespace GENEX
{
    public class SystemCoin : MonoBehaviour
    {
        [SerializeField, Header("���𭸦�"), Range(0, 2)]
        private float delayFly = 1.5f;
        [SerializeField, Header("����t��"), Range(0, 10)]
        private float speed = 1.5f;
        /// <summary>
        /// �����n�e������m
        /// </summary>
        private Transform traCoinFlyTo;

        /// <summary>
        /// �}�l����
        /// </summary>
        private bool startFly;

        private ManagerCoin managerCoin;

    private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);   //�����B�u�]�����I��
            Physics.IgnoreLayerCollision(6, 6);   //�����B�u�]�����I��        
            Physics.IgnoreLayerCollision(6, 7);   //�����B�u�]�����I��

            traCoinFlyTo = GameObject.Find("�����n�e������m").transform;
            managerCoin = GameObject.Find("�����޲z��").GetComponent<ManagerCoin>();
            Invoke("StartFly", delayFly);
        }


        private void Update()
        {
            Fly();
        }

        /// <summary>
        /// �}�l����
        /// </summary>
        private void StartFly()
        {
            startFly = true;
        }    
    
    private void  Fly()
        {
            if (!startFly) return;

            //���� : �N A B ��Ӽƭȧ�X�������w��m
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, 0.05f);
            transform.position = traCoin;
        }
        private void DestroyCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTo.position);
            
            if (dis < 2.5)
            {
                managerCoin.AddCoinAndUpdateUI();
                Destroy(gameObject);
            }

        }
    }
}