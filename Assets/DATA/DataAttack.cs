using UnityEngine;

namespace GENEX
{

    /// <summary>
    /// 攻擊資料
    /// </summary>
    [CreateAssetMenu(menuName = "GENEX/Data Attack", fileName = "Data Attack")]
    public class DataAttack : MonoBehaviour
    {
        [Header("攻擊力"), Range(0, 10000)]
        public float attack;
        [Header("攻擊力浮動"), Range(0, 100)]
        public float attackFloat;
    }
}