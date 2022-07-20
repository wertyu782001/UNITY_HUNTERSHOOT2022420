using UnityEngine;
using System.Collections;

/// <summary>
/// �ǲ߰j�� ��P�{�� Coroutine : ����
/// while.for �о�
/// while do . foreach
/// </summary>

public class LearnLoop : MonoBehaviour
{
    private void Start()
    {


        // �j��: ���ư���

        // while �j��y�k:
        // if (���L��) { �{�� } ����@��
        // while (���L��) { �{�� } ���ư��檽�쥬�L�Ȭ� false

        int count = 0;

        while (count < 5)
        {
            print("while �j�� !" + count);
            count++;
    }
        // for (��l�� ; ���� ; �j�����᪺�B�z) { �{�� }
        for (int i = 0; i < 5; i++)
        {
            print("for �j�� !" + i);
        }
        //��P�{��
        // 1. �ޥΩR�W�Ŷ� System.Collections
        // 2. �w�q�Ǧ^������ IEnumerator ����k
        // 3. yield return ����
        // 4. Start Coroutine �Ұ�
        StartCoroutine(Test());
        StartCoroutine(Loop());
    }

     private IEnumerator Test()
    {
        print("<color=yellow>�Ĥ@��<color>");
        yield return new WaitForSeconds(1);
        print("<color=yellow>�ĤG��<color>");

    }    

    private IEnumerator Loop()
    {
        for (int i = 0; i < 10; i++)
        {
            print("<color=#996611>for �j��" + i + "</color>");
            yield return new WaitForSeconds(1);
        }
    }
}
