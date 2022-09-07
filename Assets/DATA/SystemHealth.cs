using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace GENEX
{
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("畫布傷害物件")]
        private GameObject goDamge;
        [SerializeField, Header("圖片血量")]
        private Image impHp;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("怪物資料")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("敵人動畫控制器")]
        private Animator aniEneny;
        [SerializeField, Header("碰到會受傷的物件名稱")]
        private string nameHuntObject;
        [Header("玩家接收傷害區域")]
        [SerializeField] private Vector3 v3DamageSize;
        [SerializeField] private Vector3 v3DamagePosition;
        [SerializeField, Header("接收傷害的圖層")]
        private LayerMask layerDamage;

        private SystemSpawn systemSpawn;

		private void OnDrawGizmos()
		{
            Gizmos.color = new Color(0.2f, 1, 0.2f, 0.5f);
            Gizmos.DrawCube(v3DamagePosition, v3DamageSize);
		}
		private float hp;
        private string parDamage = "觸發受傷";


        private void Awake()
        {
            hp = dataEnemy.hp;
        }

		private void Update()
		{
            CheckObjectInDamageArea();
		}

		//碰撞事件
		// 1. 兩個物件必須有一個帶有 Rigidbody
		// 2. 兩個物件必須有碰撞器 Collider
		// 3. 是否有勾選 Is Trigger
		// 3-1. 兩者都沒有勾選 Is Trigger  使用 OnCollision
		private void OnCollisionEnter(Collision collision)
        {
            //print("碰撞到的物件: " + collision.gameObject);
            if (collision.gameObject.name.Contains(nameHuntObject)) 
                GetDamage(collision.gameObject.GetComponent<SystemAttack>().valueAttack);
              


        }

        private void CheckObjectInDamageArea()
        {
            Collider[] hits = Physics.OverlapBox(
                v3DamagePosition, v3DamageSize / 2,
                Quaternion.identity, layerDamage);

            if (hits.Length > 0)
            {
                GetDamage(hits[0].GetComponent<SystemAttack>().valueAttack);
                Destroy(hits[0].gameObject);
              //  print("進到受傷區域的物件:" + hits[0]);
            }
        }

        private void GetDamage(float getDamage)
        {
            
            hp -= getDamage;
            textHp.text = hp.ToString();
            impHp.fillAmount = hp / dataEnemy.hp;
            aniEneny.SetTrigger(parDamage);

            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamge, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }    

        // 死亡
        private void Dead()
        {
            //print("死亡");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
            //print(< "color=red>怪物數量:" + totalCountEnemyLive + "</color>");
            DropCoin();
        }


        /// <summary>
        /// 掉落金幣
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