﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject canvasMainMenu;
    public GameObject canvasAjustes;

    private void Start()
    {
        //canvasAjustes.SetActive(false);
    }

    //Metodos Main Menu
    //public void NuevaPartida()
    //{
    //    SceneManager.LoadScene(2);
    //}
    public void Ajustes()
    {
        canvasMainMenu.SetActive(false);
        canvasAjustes.SetActive(true);
    }
    public void ContenidoExtra()
    {

    }
    public void Creditos()
    {

    }
    public void Exit()
    {
        Application.Quit();
    }

   
}
