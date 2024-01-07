using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Game_over_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    //::::::::
    public Food food;
    //::::::
    public TextMeshProUGUI scoretext;
    void Start(){
        
    
    }
    
    public void Setup(){
        gameObject.SetActive(true);
        scoretext.text= food.score+ " scores";
    }
    public void restartButton(){
        SceneManager.LoadScene(1);
    }
    public void main_menuButton(){
        SceneManager.LoadScene(0);
    }
}
