using UnityEngine;

/// <summary>
/// �ǲ� �R�A API
/// �R�A Static
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݫ� Static Properties
        // 1. ���o get
        // ���o�R�A�ݩʻy�k:
        // ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("�e�׬�:" + Screen.width);
        print("��P�v" + Mathf.PI);
        // 2. �]�w set ( Read Only ����]�w)
        // �]�w�R�A�ݩʻy�k:
        // ���O�W��.�R�A�ݩʦW��
        Screen.brightness = 0.5f;
        Cursor.visible = false;


        //�R�A��k static methods
        // 3.�ϥ�
        // ���O�W��.�R�A��k�W��(�������޼�);
        float r = Random.Range(7.7f, 99.9f);
        print("�H��7.7 ~ 99.9 �ƭ� :" + r);
    }

    private void Update()
    {
        bool domnA = Input.GetKeyDown("a");
        print("�O�_���U A :" + domnA);
    }

}
