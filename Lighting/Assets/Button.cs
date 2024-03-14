using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("Scene2");
    }
    
    public void PreviousScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
