using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamnut : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject Message3;
    public GameObject Message4;
    public GameObject Message5;
    public GameObject Message6;
    public GameObject Message7;
    public GameObject Message8;
    public GameObject Message9;
    public GameObject Message10;


    public void OnButton1()
    {
        MainMenu.SetActive(false);
        Message1.SetActive(true);
    }
    public void OnButton2()
    {
        Message2.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton3()
    {
        Message3.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton4()
    {
        Message4.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton5()
    {
        Message5.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton6()
    {
        Message6.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton7()
    {
        Message7.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton8()
    {
        Message8.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton9()
    {
        Message9.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OnButton10()
    {
        Message10.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void OnBackButton1()
    {
        Message1.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void OnBackButton2()
    {
        Message2.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton3()
    {
        Message3.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton4()
    {
        Message4.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton5()
    {
        Message5.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton6()
    {
        Message6.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton7()
    {
        Message7.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton8()
    {
        Message8.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton9()
    {
        Message9.SetActive(false);
        MainMenu.SetActive(true);

    }
    public void OnBackButton10()
    {
        Message10.SetActive(false);
        MainMenu.SetActive(true);

    }

}