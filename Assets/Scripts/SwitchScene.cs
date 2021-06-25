using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("CutScene");
    }

    public void Continue()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Wrong()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Correct()
    {
        SceneManager.LoadScene("WinningScreen");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}