using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySpherePosition : MonoBehaviour
{
    private Vector3 spherePosition;

    void Start()
    {
        // Obtener la posición de la esfera
        spherePosition = transform.position;
        Debug.Log("La posición de la esfera es: " + spherePosition);
    }

    // Dibujar la posición en pantalla usando OnGUI()
    void OnGUI()
    {
        // Calcular el ancho del label y posicionarlo en la esquina superior derecha
        float labelWidth = 300;
        float labelHeight = 20;

        // Colocar el label en la esquina superior derecha
        GUI.Label(new Rect(Screen.width - labelWidth - 10, 10, labelWidth, labelHeight), "Posición de la esfera: " + spherePosition.ToString());
    }

}
