using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGM : MonoBehaviour
{
    public bool endgame = false;
    public float delay = 1.5f;
    public GameObject LevelComplete;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        if(endgame == false)
        {
            endgame = true;
            Invoke("Restart", delay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        LevelComplete.SetActive(true);
    }
}