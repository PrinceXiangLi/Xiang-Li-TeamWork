using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    private void Awake()
    {
        controller = this;
    }

    [Header("��ñ�������")]
    public int dieChestCount;

    [Header("�ܹ����ڵı�������")]
    public int number;

    [Header("��һ��")]
    public int scene;

    public void SetMaxChestCount(int number)
    {
        this.number = number;
    }
    /// <summary>
    /// ������������
    /// </summary>
    public void AddDieChestCount()
    {
        dieChestCount += 1;
        UIController.contronller.SetDieChestCount(dieChestCount);
        if (dieChestCount == number)
        {
            UIController.contronller.ShowResultPanel();
            Invoke("NextScene",3.5f);
            //��Ϸ����
            Debug.Log("��Ϸ����");
        }
    }
   
    public void NextScene()
    {
        SceneManager.LoadScene(scene);
    }

    // Start is called before the first frame update
    void Start()
    {
        UIController.contronller.SetChestCount(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
