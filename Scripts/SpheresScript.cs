using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresScript : MonoBehaviour
{
    public GameObject cube;
    


    void Start()
    {
        // Aumentar la altura de la esfera de tipo 2 más cercana al cubo
        IncreaseHeightOfClosestSphere();
    }

    void Update()
    {
        
        // Cambiar el color de la esfera más lejana al presionar la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColorOfFarthestSphere();
        }
    }

    void IncreaseHeightOfClosestSphere()
    {
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Tipo2");
        GameObject closestSphere = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject sphere in spheres)
        {
            float distance = Vector3.Distance(cube.transform.position, sphere.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestSphere = sphere;
            }
        }

        if (closestSphere != null)
        {
            Vector3 newPosition = closestSphere.transform.position;
            newPosition.y += 1.0f; 
            closestSphere.transform.position = newPosition;
            Debug.Log("Aumentando la altura de la esfera más cercana: " + closestSphere.name);
        }
    }

    void ChangeColorOfFarthestSphere()
    {
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Tipo2");
        GameObject[] tipo1Spheres = GameObject.FindGameObjectsWithTag("Tipo1");
        GameObject[] allSpheres = new GameObject[spheres.Length + tipo1Spheres.Length];

        spheres.CopyTo(allSpheres, 0);
        tipo1Spheres.CopyTo(allSpheres, spheres.Length);

        GameObject farthestSphere = null;
        float farthestDistance = 0.0f;

        foreach (GameObject sphere in allSpheres)
        {
            float distance = Vector3.Distance(cube.transform.position, sphere.transform.position);
            if (distance > farthestDistance)
            {
                farthestDistance = distance;
                farthestSphere = sphere;
            }
        }

        if (farthestSphere != null)
        {
            Renderer sphereRenderer = farthestSphere.GetComponent<Renderer>();
            Color newColor = new Color(Random.value, Random.value, Random.value); 
            sphereRenderer.material.color = newColor;

            Debug.Log("Cambiando el color de la esfera más lejana: " + farthestSphere.name + " a " + newColor);
        }
    }
}

