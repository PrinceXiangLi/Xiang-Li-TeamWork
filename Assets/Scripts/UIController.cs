using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController contronller;

    public void Awake()
    {
        contronller = this;
    }

    [Header("��õı�������")]
    public Text dieChestText;

    [Header("����������ʾ�ı�")]
    public Text chestCountText;


    public void SetDieChestCount(int dieChestCount)
    {
        dieChestText.text = dieChestCount.ToString();
    }

    public void SetChestCount(int chestCount)
    {
        chestCountText.text = chestCount.ToString();
    }

    #region ��Ϸ���������߼�
    [Header("��Ϸ������������")]
    public GameObject resultPanel;

    public void Restart(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void intoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowResultPanel()
    {
        resultPanel.SetActive(true);   
    }
    #endregion
}