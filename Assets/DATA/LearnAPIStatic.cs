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

    }


}
