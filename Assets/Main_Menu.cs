using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void PlayButton(){
        SceneManager.LoadScene(1);
    }
    public void PlayLevel1(){
        SceneManager.LoadScene(1);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
