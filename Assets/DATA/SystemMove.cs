using UnityEngine;
using System.Collections;

namespace GENEX
{    
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class SystemMove : MonoBehaviour
    {   
        /// <summary>
        ///�^�X�t�� 
        /// </summary>
        private SystemTurn systemTurn;
        private float moveDistance = 2;

        private void Awake()
        {
            systemTurn =  GameObject.Find("�^�X�t��").GetComponent<SystemTurn>();
            systemTurn.onTurnEnemy.AddListener(() => { StartCoroutine(Move()); });

        }

        private IEnumerator Move()
        {
            //print(gameObject + " ���e����");
            float moveCount = 10;
            float perDistance = moveDistance / moveCount;
            for (int i = 0; i< moveCount; i++)
            {
                transform.position -= new Vector3(0, 0, perDistance);
                yield return new WaitForSeconds(0.05f);
            }
        }



    }
}