using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{

    public static string previousScene = "";

    public void ChangeMenuScene(string sceneName)
    {
        previousScene = SceneManager.GetActiveScene().name;
        //float fadeTime = GameObject.Find("_GM").GetComponent<fade>().BeginFade(1);
        //yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(sceneName);
        Debug.Log("Button");
    }

    public void ReturnToPreviousScene()
    {
        SceneManager.LoadScene(previousScene);
    }

}