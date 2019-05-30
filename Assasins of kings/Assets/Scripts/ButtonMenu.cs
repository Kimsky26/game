using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
