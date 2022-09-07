using UnityEngine;


namespace GENEX
{

    public class SystemMarble : MonoBehaviour
    {
        [SerializeField, Header("怪物圖層")]
        private LayerMask layerMask;
        [SerializeField, Header("幾秒沒有碰到怪物要回收"), Range(0, 10)]
        private float timeRecycle = 5;
        [SerializeField, Header("回收速度")]
        private Vector3 v3SpeedRecycle;

        private float timer;

    }
}