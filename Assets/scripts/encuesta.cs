using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class encuesta : MonoBehaviour
{
    void start(){ 
    aviso.SetActive(false);
    }
    public GameObject aviso;
    
    public void Ingresar()
    {
        bool usuarioEncontrado = false;
        string input_usuario = GameObject.Find("Usuario").GetComponent<TMP_InputField>().text;
        string input_contraseña = GameObject.Find("Contrasena").GetComponent<TMP_InputField>().text;
        string[,] usuarios = { {"Nombre","Contraseña" },{ "Santiago", "Santiago123" }, { "Julian", "Julian123"}, {"Pablo","Pablo123"}, {"Carlos","Carlos123"}
        };
        
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (input_usuario == usuarios[i, 0] && input_contraseña == usuarios[i, 1])
            {
                usuarioEncontrado = true;
                print("Has iniciado sesiòn");
                SceneManager.LoadScene("Menu");
                break;
            }
            else
            {
                aviso.SetActive(true);
                print("Verificar credenciales");
                
            }
        }
    }
    
    /*public void Buenas() { 
    string input_Buenas = 
    }
    public void Malas()
    {
    string input_Buenas =
    }
    public void Neutras()
    {
    string input_Buenas =
    }*/
}
