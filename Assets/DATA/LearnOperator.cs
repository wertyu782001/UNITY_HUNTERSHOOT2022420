using UnityEngine;

public class LearnOperator: MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private int diamond = 1;
    private int hp = 100;

    private void Start()
    {
        #region �ƾǹB��l

        // �[ +
        // �� -
        // �� *
        // �� /
        // �l %
        print("�[�k:" + (a + b));  // 13
        print("��k:" + (a - b));  // 7
        print("���k:" + (a * b));  // 30
        print("���k:" + (a / b));  // 3.3333
        print("�l�k:" + (a % b));  // 1
        #endregion

        #region ����B��l

        // �p�� <
        // �j�� >
        // �p�󵥩� <=
        // �j�󵥩� >= 
        // ������ !=
        // ���� ==

        //����B��l�����G�����L��: true�Bfalse
        print("�p�� :" + ( c < d));  // false
        print("�j�� :" + (c > d));  // true
        print("�p�󵥩� :" + (c <= d));  // false
        print("�j�󵥩� :" + (c >= d));  // true
        print("������ :" + (c < d));  // true
        print("���� :" + (c == d));  // false

        #endregion

        #region �޿�B��l
        //�޿�B��l�A�w�塞�L��
        //�åB&&:��ӥ��L�Ȧ��@�� false ���G�� false
        print(" true && true" + (true && true));  // true
        print(" true && false" + (true && false));  // false
        print(" false && true" + (true && false));  // false
        print(" false && false" + (true && false));  // false

        // �άO || : ��ӥ��L�Ȧ��@��  ���G�� false
        print(" true || true" + (true || true));  // true
        print(" true || false" + (true || false));  // true
        print(" false || true" + (true || false));  // true
        print(" false || false" + (true || false));  // false

        //�C���d��:
        //�ӧQ����: �_�� >= �åB��q �j�� 0 �~��L��
        print("�O�_�L�� : " + (diamond >= 3 && hp > 0));  //false
        #endregion

        #region �A�˹B��l
        // �A�˹B��l ! 
        // �@�� : �N���L���ܬۤ�
        print(" !true " + (!true));  // false
        print(" !false" + (!false));  // true
        #endregion

       
    }
}
