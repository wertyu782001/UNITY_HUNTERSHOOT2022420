using UnityEngine;


namespace GENEX
{

    public class SystemMarble : MonoBehaviour
    {
        [SerializeField, Header("�Ǫ��ϼh")]
        private LayerMask layerMask;
        [SerializeField, Header("�X��S���I��Ǫ��n�^��"), Range(0, 10)]
        private float timeRecycle = 5;
        [SerializeField, Header("�^���t��")]
        private Vector3 v3SpeedRecycle;

        private float timer;

    }
}