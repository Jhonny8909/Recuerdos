using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarNota : MonoBehaviour
{
    Collect collect;
    public GameObject Objetivo;

    void Update()
    {
        if (collect.activado)
        {
            Objetivo.SetActive(true);
        }
    }
}
