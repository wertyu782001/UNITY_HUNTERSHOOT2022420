using UnityEngine;

public class Car : MonoBehaviour
{
    //���q
    [Tooltip("�T�������q�A���q�O��"), Header("�T�������q"), Range(1, 60)]
    public int weight = 3;
    //����
    [Tooltip("�T�������סA���׬O����"), Header("�T��������"), Range(1, 200)]
    public float height = 3.5f;
    //�~�P
    [Tooltip("�T�����~�P����"), Header("�T�����~�P")]
    public string brand = "���}" ;
    //�O�_���ѵ�
    [Tooltip("�T���O�_���ѵ�"), Header("�ѵ�")]
    public bool hasSkywindow = true;
}
