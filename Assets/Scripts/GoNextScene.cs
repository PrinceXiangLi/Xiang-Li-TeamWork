using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour
{
    public void PlayGame(int num)
    {
        SceneManager.LoadScene(num);
    }
}
