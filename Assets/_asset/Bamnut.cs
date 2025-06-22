using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bamnut : MonoBehaviour
{

    public GameObject Message1;
    public GameObject Message2;
    public GameObject Message3;
    public GameObject Message4;
    public GameObject Message5;
    public GameObject Message6;
    public GameObject Message7;
    public GameObject Message8;


    public void OnButton1()
    {
        Message1.SetActive(true);
    }
    public void OnButton2()
    {
        Message2.SetActive(true);
    }
    public void OnButton3()
    {
        Message3.SetActive(true);
    }
    public void OnButton4()
    {
        Message4.SetActive(true);
    }
    public void OnButton5()
    {
        Message5.SetActive(true);
    }
    public void OnButton6()
    {
        Message6.SetActive(true);
    }
    public void OnButton7()
    {
        Message7.SetActive(true);
    }
    public void OnButton8()
    {
        Message8.SetActive(true);
    }

    public void OnBackButton1()
    {
        Message1.SetActive(false);
    }
    public void OnBackButton2()
    {
        Message2.SetActive(false);
    }
    public void OnBackButton3()
    {
        Message3.SetActive(false);
    }
    public void OnBackButton4()
    {
        Message4.SetActive(false);
    }
    public void OnBackButton5()
    {
        Message5.SetActive(false);
    }
    public void OnBackButton6()
    {
        Message6.SetActive(false);
    }
    public void OnBackButton7()
    {
        Message7.SetActive(false);
    }
    public void OnBackButton8()
    {
        Message8.SetActive(false);
    }
}