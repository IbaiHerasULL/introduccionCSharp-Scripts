using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public int frameDelay = 120;

    private int frameCount = 0;

    private Color currentColor;

    private Renderer objectRenderer;

    // Start is called before the first frame update
    void Start()
    {

        currentColor = new Color(Random.value, Random.value, Random.value);

        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer != null)
        {
            objectRenderer.material.color = currentColor;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;

        if (frameCount>=frameDelay){
            frameCount = 0;

            int index = Random.Range(0,3);

            float newColorValue = Random.value;

            switch (index)
            {
                case 0:

                currentColor.r = newColorValue;

                break;

                case 1:

                currentColor.g = newColorValue;

                break;
                case 2:

                currentColor.b = newColorValue;

                break;
                
            } 

            if (objectRenderer != null)
            {
                objectRenderer.material.color = currentColor;
            }

        }

        
    }
}
