using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    static public GameManager instance { get; private set; }//Encapsulation
    [SerializeField] GameObject player;
    [SerializeField] GameObject coins;
    Vector3 coinsPosition;

    Vector3 playerPosition;
    float x;
    float y;
    float z;
    float xCoin;
    float yCoin;
    float zCoin;
    float rate;
    float delay;
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
        StartGame();
    }
    private void Update()
    {
        xCoin = Random.Range(-15, 15);
        zCoin = Random.Range(-15, 15);
    }

    public void StartGame()//abstration
    {
        delay = 5;
        rate = 2;
        score = 0;
        health = 10;
        scoreText.text="Score: "+ score;
        healthText.text="Health "+ health;
        //initial player position
        if(player)
        {
            player.transform.position= playerPosition;
        }
        InvokeRepeating("SpawnCoins", delay, rate);
      } 
        public void GameOver()//abstraction
        {

        }
    public void addScore(int m_score)//abstracction
    {
        score+=m_score;
        scoreText.text = "Score " + score;
    }
    public void SubtractHealth(int m_health)//abstraction
    {
        health -= m_health;
        healthText.text = "Health:" + health;
        if (health == 0)
        {
            GameOver();
        }
            
    }
    void SpawnCoins()//abstration
    {
        coinsPosition = new Vector3(xCoin, yCoin, zCoin);
        Instantiate(coins, coinsPosition, transform.rotation);
    }
}
