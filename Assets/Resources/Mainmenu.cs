using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public AudioSource bgmMainMenu;

    private void Start()
    {
        bgmMainMenu.Play();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("InGame");
    }
}
