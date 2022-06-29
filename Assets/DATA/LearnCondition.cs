using UnityEngine;

public class LearnCondition : MonoBehaviour
{

    public bool opendoor;
    public int combo;
    public string prop;

    /// <summary>
    /// ����(�P�_��)
    /// 1.if
    /// 2.switch
    /// </summary>
    /// 
    public enum StatePlayer
    {
        Idle, Walk, Hurt, Run, Attack, Dead
    }

    public StatePlayer statePlayer;


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

        #region combo�[���P��
        if (combo < 100)
        {
            print("�����O + 0%");
        }


        if (combo >= 200)
        {
            print("�����O + 20%");
        }


        if (combo >= 100)
        {
            print("�����O + 10%");
        }
        #endregion


        #region �P�_�� switch
        switch (prop)
        {
            case "�����Ĥ�":
                print("�ɦ�");
                break;

            case "�����Ĥ�":
                print("�ܫi��");
                break;

            case "����Ĥ�":
                print("�[�t");
                break;

            default:
                print("�L���D��");
                break;
        }
        #endregion

        #region SWITCH

        switch (statePlayer)
        {
            case StatePlayer.Idle:
                print("�ݾ�");
                break;
            case StatePlayer.Walk:
                print("����");

                break;
            case StatePlayer.Hurt:
                print("����");
                break;
            case StatePlayer.Run:
                print("�]�B");
                break;
            case StatePlayer.Attack:
                print("����");
                break;
            case StatePlayer.Dead:
                print("���`");
                break;

            default:
                print("�S��");
                break;
        }
        #endregion

    }


}
