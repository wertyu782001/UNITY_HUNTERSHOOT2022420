using UnityEngine;
using UnityEngine.Events;
namespace GENEX
{
    /// <summary>
    /// �^���ϰ�
    /// </summary>
    public class RecycleArea : MonoBehaviour
{
        /// <summary>
        /// �^���u�]�ƥ�
        /// </summary>
        public UnityEvent onRecycle;

        
        // ��ӸI�����䤤�@�ӤĿ� Is Trigger
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("�u�]"))
            {
                //print("�^���u�]");
                onRecycle.Invoke();
            }
        }
    }
}