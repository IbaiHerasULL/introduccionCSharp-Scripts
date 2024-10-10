using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    // Vectores públicos que podrás editar desde el Inspector
    public Vector3 vectorA;
    public Vector3 vectorB;

    // Variables para mostrar los resultados en el Inspector
    public float magnitudeA;
    public float magnitudeB;
    public float angleBetweenVectors;
    public float distanceBetweenVectors;
    public string higherVector;

    void Start()
    {
        // Calculamos la magnitud de cada vector
        magnitudeA = vectorA.magnitude;
        magnitudeB = vectorB.magnitude;

        // Calculamos el ángulo entre los dos vectores en grados
        angleBetweenVectors = Vector3.Angle(vectorA, vectorB);

        // Calculamos la distancia entre ambos vectores
        distanceBetweenVectors = Vector3.Distance(vectorA, vectorB);

        // Determinamos cuál vector está a mayor altura (componente 'y')
        if (vectorA.y > vectorB.y)
        {
            higherVector = "Vector A está a mayor altura";
        }
        else if (vectorA.y < vectorB.y)
        {
            higherVector = "Vector B está a mayor altura";
        }
        else
        {
            higherVector = "Ambos vectores están a la misma altura";
        }

        // Mostrar resultados en la consola
        Debug.Log("Magnitud de Vector A: " + magnitudeA);
        Debug.Log("Magnitud de Vector B: " + magnitudeB);
        Debug.Log("Ángulo entre Vector A y Vector B: " + angleBetweenVectors + " grados");
        Debug.Log("Distancia entre Vector A y Vector B: " + distanceBetweenVectors);
        Debug.Log(higherVector);
    }
}

