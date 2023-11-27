using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameScene()
    {
        SceneManager.LoadScene("S_Content_Overview");
        print("cragar juego");
        Debug.Log("cargar juego");
    }

    public void GameExit()
    {
        Application.Quit();
        print("cierra juego");
        Debug.Log("cierra juego");
    }

    public void OptionsScene()
    {
        SceneManager.LoadScene("Options");
        Debug.Log("cargar opciones");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("cargar opciones");
    }
}
