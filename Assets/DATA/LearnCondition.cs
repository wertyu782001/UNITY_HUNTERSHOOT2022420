using UnityEngine;

public class LearnCondition : MonoBehaviour
{

    public bool opendoor;
    public int combo;

    /// <summary>
    /// ����(�P�_��)
    /// 1.if
    /// 2.switch
    /// </summary>

    private void Start()
    {
        #region if �P�_��
        // if �y�k:
        // if (���L��) { ���L�ȵ��� true �|���� }
        if (true)
        {
            print("�ڦb�P�_�� if ��");
        }
        #endregion
    }

    private void Update()
    {
        //�p�G openDoor ���� true �N�}���A�_�h�N����
        //�p�G
        // if �y�k:
        // if(���L��) { ���L�ȵ��� true �|���� )
        // �_�h 
        // else {���L�ȵ��� false �|����}
        if (opendoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
    }
}
// else if () {}
// �L���ƶq
// �s