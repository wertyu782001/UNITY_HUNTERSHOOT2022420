using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace GENEX
{
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("�e���ˮ`����")]
        private GameObject goDamge;
        [SerializeField, Header("�Ϥ���q")]
        private Image impHp;
        [SerializeField, Header("��r��q")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("�Ǫ����")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("�ĤH�ʵe���")]
        private Animator aniEneny;

        private SystemSpawn systemSpawn;
        private float hp;
        private string parDamage = "Ĳ�o����";

        private void Awake()
        {
            hp = dataEnemy.hp;
        }

        //�I���ƥ�
        // 1. ��Ӫ��󥲶����@�ӱa�� Rigidbody
        // 2. ��Ӫ��󥲶����I���� Collider
        // 3. �O�_���Ŀ� Is Trigger
        // 3-1. ��̳��S���Ŀ� Is Trigger  �ϥ� OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            // print("�I���쪺����: " + collision.gameObject);

            GetDamage();

        }
        private void GetDamage()
        {
            float getDamage = 50;
            hp -= getDamage;
            textHp.text = hp.ToString();
            impHp.fillAmount = hp / dataEnemy.hp;
            aniEneny.SetTrigger(parDamage);

            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamge, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }    

        // ���`
        private void Dead()
        {
            //print("���`");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
            //print(< "color=red>�Ǫ��ƶq:" + totalCountEnemyLive + "</color>");
            DropCoin();
        }


        /// <summary>
        /// ��������
        /// </summary>
       private void DropCoin()
        {
            int range = Random.Range(dataEnemy.v2CoinRange.x, dataEnemy.v2CoinRange.y);
            
            for(int i = 0;i <range; i++)
            {
                Instantiate(
                    dataEnemy.goCoin,
                    transform.position + new Vector3(0, 2, 0),
                    Quaternion.Euler(90, 180, 0)) ;
            }
        
        }
    }
}