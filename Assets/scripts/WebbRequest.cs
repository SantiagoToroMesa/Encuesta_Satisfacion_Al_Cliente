using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.Networking;

public class WebbRequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetTexT());
    }
    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://www.google.com/search?q=gatos");
        yield return www.Send();

        if (www.isNetworkError)
        {
            Debug.Log("www.error");
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            strig[] datos = www.downloadHandler.text.Split("<");
            Debug.Log(datos[3]);

            byte[] results = www.downloadHandler.data;
        }
    }
}