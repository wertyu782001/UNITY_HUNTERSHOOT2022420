using UnityEngine;

namespace GENEX
{
    // Scriptableobject �}���ƪ���: �}�����e�ܦ������Ʀs��b Project ��
    // �����f�t CreateAssetMenu
    [CreateAssetMenu(menuName = "GENEX/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("��q"), Range(0, 10000)]
        public float hp;
        [Header("�ˮ`"), Range(0, 10000)]
        public float damage;
    }

}