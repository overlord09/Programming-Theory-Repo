using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Restart : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gameOverText;
    private void Start()
    {
        if(GameManager.instance)
        {
            gameOverText.text = "Game over! You Scored: "+GameManager.instance.score;
        }
       
    }
    public void onclickRestart()//abstraction
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.StartGame();

        }
       if(LoadScreen.Instance!=null)
        {
            LoadScreen.Instance.LoadScene(1);
        }
    
    }
   

}
