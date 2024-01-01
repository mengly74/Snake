using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game_over_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoretext;
    void Start(){
        
    
    }
    
    public void Setup(int score){
        gameObject.SetActive(true);
        scoretext.text= score.ToString()+"points";
    }
    public void restartButton(){
        SceneManager.LoadScene("Snake1");
    }
    public void main_menuButton(){
        SceneManager.LoadScene(0);
    }
}
