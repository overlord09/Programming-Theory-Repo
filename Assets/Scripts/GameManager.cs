using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    static public GameManager instance { get; private set; }//Encapsulation
    [SerializeField] GameObject player;
    Vector3 playerPosition;
    float x;
    float y;
    float z;
    int score;
    int health;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI healthText;



    // Start is called before the first frame update
    void Start()
    {
       if (instance != null)
        {
            Destroy(gameObject);

        }
       instance = this;
        DontDestroyOnLoad(gameObject);
       
       //initialize variables for the player position 
        x = 1.5f;
        y = 1.0f;
        z = 1.5f;
        
       playerPosition=new Vector3(x, y, z);
    }

    public void StartGame()
    {
        score = 0;
        health = 10;
        scoreText.text="Score: "+ score;
        healthText.text="Health "+ health;
        //initial player position
        if(player)
        {
            player.transform.position= playerPosition;
        }
      } 
        public void GameOver()
        {

        }
    public void addScore(int m_score)
    {
        score+=m_score;
        scoreText.text = "Score " + score;
    }
    public void SubtractHealth(int m_health)
    {
        health -= m_health;
        healthText.text = "Health:" + health;
        if (health == 0)
        {
            GameOver();
        }
            
    }
}
