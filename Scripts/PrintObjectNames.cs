using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObjectNames : MonoBehaviour
{
    void Start()
    {
        Debug.Log("El nombre de este objeto es: " + gameObject.name);
    }
}
