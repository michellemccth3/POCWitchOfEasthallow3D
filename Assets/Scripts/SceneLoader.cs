using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    
    public void LoadTutorial()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 1");
    }

}
