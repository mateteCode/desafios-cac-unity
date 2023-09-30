using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject hud;

    void Start()
    {
        PauseGame();
    }

    public void PlayGame() {
        mainMenu.SetActive(false);
        hud.SetActive(true);
    }
    public void PauseGame() {
        mainMenu.SetActive(true);
        hud.SetActive(false);
    }
    public void ExitGame() {
        Debug.Log("Saliendo del juego");
        Application.Quit();
    }
}
