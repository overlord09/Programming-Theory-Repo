using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{

    public static LoadScreen Instance { get; private set; }//encapsulation
    public bool gameStarted;
    int Screenloading = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);

        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadGame());
        
    }
    IEnumerator LoadGame()//abstraction
    {
        yield return new WaitForSeconds(5);
        LoadScene(Screenloading);
        gameStarted = true;
    }
    public void LoadScene(int m_scene)
    {
        Screenloading = m_scene;
        SceneManager.LoadScene(Screenloading);
    }

    
}
