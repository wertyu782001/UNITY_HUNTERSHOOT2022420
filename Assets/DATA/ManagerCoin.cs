using UnityEngine;
using TMPro;

namespace GENEX
{ 
    /// <summary>
    /// �޲z����: ��s�����ƶq
    /// </summary>
    public class ManagerCoin : MonoBehaviour
    {  
        /// <summary>
        /// �����ƶq
        /// </summary>
        private TextMeshProUGUI textCoin;
        /// <summary>
        /// �����`��
        /// </summary>
        private int totalCoin;
        private void Awake()
        {
            textCoin = GameObject.Find("�����ƶq").GetComponent<TextMeshProUGUI>();
        }

        public void AddCoinAndUpdateUI()
        {
            totalCoin++;
            textCoin.text = totalCoin.ToString();
        }
    }
}