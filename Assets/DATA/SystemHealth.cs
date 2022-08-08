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


        private float hp;

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
            hp -= 50;
            textHp.text = hp.ToString();
            impHp.fillAmount = hp / dataEnemy.hp;

            if (hp <= 0) Dead();
        }    

        // ���`
        private void Dead()
        {
            print("���`");
        }
    }
}