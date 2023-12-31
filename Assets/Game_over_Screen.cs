using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game_over_Screen : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoretext;
    void Start(){
        scoretext = GameObject.FindObjectOfType<Text>();
    
    }
    public void Setup(int score){
        gameObject.SetActive(true);
        scoretext.text=score+"points";
    }
}
