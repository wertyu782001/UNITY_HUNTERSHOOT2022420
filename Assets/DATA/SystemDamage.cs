using UnityEngine;
using TMPro;
using System.Collections;

namespace GENEX
{
    #region �ˮ`�Ʀr
    /// <summary>
    /// �ˮ`�Ʀr : ��s�ˮ`�Ʀr�B�C��H�ΰʺA�ĪG
    /// </summary>
    public class SystemDamage : MonoBehaviour
    {
        /// <summary>
        /// �ˮ`�Ʀr
        /// </summary>
        public float damage;

        [SerializeField, Header("�j�� 100 �C��")]
        private Color colorGratherThan100 = new Color(0.2f, 0.7f, 0.6f);

        [SerializeField, Header("�j�� 200 �C��")]
        private Color colorGratherThan200 = new Color(0.8f, 0.4f, 0.5f);

        private float limitup;
        private float limitRight;
        private TextMeshProUGUI textDamage;
        #endregion

        [SerializeField, Header("�ĪG���j")]
        private float interval = 0.025f;

        private void Start()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();

            if (damage >= 200) textDamage.color = colorGratherThan200;
            else if (damage >= 100) textDamage.color = colorGratherThan100;

            limitup = Random.Range(50, 80);

            int r = Random.Range(0, 2);
            if (r == 0) limitRight = -50;
            else if (r == 1) limitRight = 50;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());
        }
        
        private IEnumerator MovementUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitup;
                yield return new WaitForSeconds(interval);
            }
            
            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitup;
                yield return new WaitForSeconds(interval);
            }

            for (int i = 0; i < 10; i++)
            {
                textDamage.color -= new Color(0, 0, 0, 0.1f);
                yield return new WaitForSeconds(interval);
            }
        }




        private IEnumerator MovementRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitRight;
                yield return new WaitForSeconds(interval);
            }
        }

        private IEnumerator ScaleEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.0001f;
                yield return new WaitForSeconds(interval);
            }

            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.0001f;
                yield return new WaitForSeconds(interval);
            }
        }
    }
}