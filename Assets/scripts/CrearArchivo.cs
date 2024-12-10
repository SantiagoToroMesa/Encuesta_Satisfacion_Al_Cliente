using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CrearArchivo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("creando archivo ...");
        string ruta = "C:\\Users\\broke\\Encuesta_Satisfacción_Al_Cliente\\Assets\\GestionOpiniones\\BD\\";
        string nombreArchivo = "nombreArchivo.storom";
        string Contenido = "Nombre;Email;URL\njuan;juan@juan.com;http://www.juan.com";
        File.WriteAllText(ruta + nombreArchivo, Contenido);
        print("se ha creado el archivo correctamente. ");
        // mostrar el contenido de el archivo
        print("Leyendo Contenido");
        string leerTexto = File.ReadAllText(ruta + nombreArchivo);
        string[] dbfilas = leerTexto.Split('\n');
        string[] dbcolumna = dbfilas[0].Split(";");
        print(dbcolumna[2]);
        print(leerTexto);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
