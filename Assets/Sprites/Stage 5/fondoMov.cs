using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoMov : MonoBehaviour
{
    [SerializeField] public Vector2 velocidadMov;

    private Vector2 offset;

    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;

    }

    private void Update()
    {
        offset = velocidadMov * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
