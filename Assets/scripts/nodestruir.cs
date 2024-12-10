using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodestruir : MonoBehaviour
{
    public string Positivos;
    public string Negativos;
    public string Neutrales;

    public static nodestruir Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    

    }
}
