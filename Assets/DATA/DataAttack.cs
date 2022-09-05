using UnityEngine;

namespace GENEX
{

    /// <summary>
    /// �������
    /// </summary>
    [CreateAssetMenu(menuName = "GENEX/Data Attack", fileName = "Data Attack")]
    public class DataAttack : MonoBehaviour
    {
        [Header("�����O"), Range(0, 10000)]
        public float attack;
        [Header("�����O�B��"), Range(0, 100)]
        public float attackFloat;
    }
}