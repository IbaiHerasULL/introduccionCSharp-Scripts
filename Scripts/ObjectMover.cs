using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    // Variables públicas para el desplazamiento configuradas desde el Inspector
    public Vector3 desplazamientoCubo; 
    public Vector3 desplazamientoEsfera; 
    public Vector3 desplazamientoCilindro; 

    public GameObject cubo;
    public GameObject esfera; 
    public GameObject cilindro; 

    void Update()
    {
        // Detectar si se ha pulsado la barra espaciadora
        if (Input.GetAxis("Jump") > 0)
        {
            // Mover cada objeto a su nueva posición 
            cubo.transform.position = desplazamientoCubo;
            esfera.transform.position = desplazamientoEsfera;
            cilindro.transform.position = desplazamientoCilindro;

            Debug.Log("Nueva posición del cubo: " + cubo.transform.position);
            Debug.Log("Nueva posición de la esfera: " + esfera.transform.position);
            Debug.Log("Nueva posición del cilindro: " + cilindro.transform.position);
        }
    }
}

