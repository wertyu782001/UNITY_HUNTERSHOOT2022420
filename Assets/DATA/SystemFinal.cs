using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class SystemFinal : MonoBehaviour
{   /// <summary>
    /// �C�������e������ 
    /// </summary>
    private CanvasGroup groupFinal;
    /// <summary>
    /// �C�������p���D
    /// </summary>
    private TextMeshProUGUI textSubTitle;
    /// <summary>
    /// ���s�C��
    /// </summary>
    private Button btnReplay;
    /// <summary>
    /// ���}�C��
    /// </summary>
    private Button btnQuit;

	private void Awake()
	{
        groupFinal = GameObject.Find("�C�������e������").GetComponent<CanvasGroup>();
        textSubTitle = GameObject.Find("�C�������p���D").GetComponent<TextMeshProUGUI>();
        btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
        btnQuit = GameObject.Find("���}�C��").GetComponent<Button>();
        btnReplay.onClick.AddListener(Replay);                 //  ���U���s�C�����s�� ���� Replay ��k
        btnQuit.onClick.AddListener(Quit);                     //  ���U���}�C�����s�� ���� Quit ��k

    }

    /// <summary>
    /// ��ܵ����e���ç�s�p���D
    /// </summary>
    /// <param name="subTitle"></param>
    public void ShowFinalAndUpdateSubTitle(string subTitle)
    {
        textSubTitle.text = subTitle;
        StartCoroutine(ShowFinal());
    }


    /// <summary>
    /// ��ܤ���
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShowFinal()
    {
        for (int i = 0; i < 10; i++)
        {
            groupFinal.alpha += 0.1f;
            yield return new WaitForSeconds(0.03f);
        }

        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;


    }

    /// <summary>
    /// ���s�C���\��
    /// </summary>
	private void Replay()
	{
        string nameCurrent = SceneManager.GetActiveScene().name;  // ���o��e�����W��
        SceneManager.LoadScene(nameCurrent);                      // �����޲z.���J����(�W��)
	}

	private void Quit()
	{
        Application.Quit();  //���ε{��.���}() ; - �����C���AUnity ���L�@��
	}



}



