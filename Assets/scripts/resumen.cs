using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro.Examples;
using TMPro;

public class resumen : MonoBehaviour
{

    //string GameObject.Find("TextPositive");
    public TMP_Text Positivas;
    public TMP_Text Negativas;
    public TMP_Text Neutrales;
    public TMP_Text Totales;
    
    void Start() { 
        Positivas.text = GameObject.Find("datos").GetComponent<nodestruir>().Positivos;
        Negativas.text = GameObject.Find("datos").GetComponent<nodestruir>().Negativos;
        Neutrales.text = GameObject.Find("datos").GetComponent<nodestruir>().Neutrales;

    }



    //contadores contador = new contadores(cpositivas,cneutrales,cnegativas);












}
