using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript: MonoBehaviour
{
    private GameObject cubo;
    private GameObject cilindro;

    void Start()
    {
        // Buscar el cubo y el cilindro por sus etiquetas
        cubo = GameObject.FindWithTag("Cubo");
        cilindro = GameObject.FindWithTag("Cilindro");

        if (cubo != null && cilindro != null)
        {
            Vector3 posicionEsfera = transform.position;
            Vector3 posicionCubo = cubo.transform.position;
            Vector3 posicionCilindro = cilindro.transform.position;

            // Calcular la distancia desde la esfera al cubo
            float distanciaCubo = Vector3.Distance(posicionEsfera, posicionCubo);

            // Calcular la distancia desde la esfera al cilindro
            float distanciaCilindro = Vector3.Distance(posicionEsfera, posicionCilindro);

            Debug.Log("Distancia de la esfera al cubo: " + distanciaCubo);
            Debug.Log("Distancia de la esfera al cilindro: " + distanciaCilindro);
        }
        
    }
}

