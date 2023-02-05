using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    public GameObject Puertas;
    void Update()
    {
        if (Puertas == false)
        {
            Puertas.SetActive(true);
        }
    }
}
