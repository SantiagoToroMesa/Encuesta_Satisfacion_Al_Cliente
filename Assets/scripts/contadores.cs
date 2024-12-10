using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using TMPro.Examples;

public class contadores : MonoBehaviour
{
    public GameObject avisobien;
    public GameObject avisomal;
    public GameObject avisoneutral;
    int cpositivas = 0;
    int cnegativas = 0;
    int cneutrales = 0;
    private void Start()
    {
        avisobien.SetActive(false);
        avisomal.SetActive(false);
        avisoneutral.SetActive(false);
    }
    public void positivas()
    {
        avisobien.SetActive(true);
        cpositivas++;
        Debug.Log("positivas: " + cpositivas);
        GameObject.Find("datos").GetComponent<nodestruir>().Positivos = cpositivas.ToString();
        //ctotal = ctotal + negativas(ctotal) + neutrales(ctotal)
    }

    public void negativas()
    {
        avisomal.SetActive(true);
        cnegativas++;
        Debug.Log("negativas: " + cnegativas);
        GameObject.Find("datos").GetComponent<nodestruir>().Negativos = cnegativas.ToString();
        //ctototalizado = ctotal + neutrales(ctotal) + positivas(ctotal);
    }
    public void neutrales()
    {
        avisoneutral.SetActive(true);
        cneutrales++;
        Debug.Log("neutrales: " + cneutrales);
        GameObject.Find("datos").GetComponent<nodestruir>().Neutrales = cneutrales.ToString();
        //ctototalizado = ctotal +  negativas(ctotal) + positivas(ctotal);
    }

}