using UnityEngine;


/// <summary>
/// �ǲ� �D�R�A API
/// API ���W�S�� static
/// </summary>

public class LenrnAPINOstatic : MonoBehaviour
{
    public Transform traA;
    public Light lightA;
    public Transform traB;
    public void Start()
    {
        // �D�R�A�ݩ� properties
        // 1. ���o get 
        // ���� :
        // -�����O�������
        // -���骫��
        // -���s��ӹ��骫��
        // ���W��.�D�R�A�ݩʦW��
        print(" A ���󪺮y��" + traA.position);
        print("�O���C��" + lightA.color);
        // 2.�]�w set
        // ���W��.�D�R�A�ݩʦW�� ���w ��;
        traA.position = new Vector3(1.57f, 0.5f, -15);
        lightA.color = new Color(1, 0, 0);
    }

    public void Update()
    {
        // �D�R�A��k methods
        // 3.�ϥ�
        // ���W��.�D�R�A�ݩʦW��(�����޼�)
        traB.Rotate(0, 5, 0);
    }
}

