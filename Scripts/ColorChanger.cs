using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject cubo;
    public GameObject cilindro;

    void Update()
    {
        // Cambiar color del cilindro al pulsar la tecla "C"
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeCylinderColor();
        }

        // Cambiar color del cubo al pulsar la flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeCubeColor();
        }
    }

    void ChangeCylinderColor() //Función para cambiar el color del cilindro
    {
        Renderer cilindroRenderer = cilindro.GetComponent<Renderer>();
        Color nuevoColor = new Color(Random.value, Random.value, Random.value); 
        cilindroRenderer.material.color = nuevoColor;
        Debug.Log("Color del cilindro cambiado a rojo.");
    }

    void ChangeCubeColor() //Función para cambiar el color del cubo
    {
        Renderer cuboRenderer = cubo.GetComponent<Renderer>();
        Color nuevoColor = new Color(Random.value, Random.value, Random.value); 
        cuboRenderer.material.color = nuevoColor;
        Debug.Log("Color del cubo cambiado a azul.");
    }
}

