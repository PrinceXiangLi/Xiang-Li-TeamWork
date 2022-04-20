using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour {
    public GameObject plane;
    public GameObject text;
    public int TotalTime = 60;

    void Start()
    {

        StartCoroutine(countDown());

    }
    

    IEnumerator countDown()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
           
        }
        
    }
void Update()
    {
      if (TotalTime==0)
            {
                plane.SetActive(true);
            }
    }


}
