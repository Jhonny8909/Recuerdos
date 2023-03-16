using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadradosSimonDice : MonoBehaviour
{
    public int idCube;
    public bool Desactivando;
    public bool Desactivado;
    public AudioSource Sonido;
    public Controlador controlador;
   


    // Start is called before the first frame update


    public void Start()
    {
       
    }
    public void ActivarCubo()
    {
        Desactivado = false;
        Desactivando = false;

        //llamar a controlador para decirle que hemos hecho click a este cubo
        if (controlador.turnoJug) { 
        controlador.ClickUsuario(idCube);
        }
        Sonido.Play();
        
       Invoke("DesactivarCubo",0.1f);


    }

    public void DesactivarCubo()
    {
        Desactivando = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        print(name);
        Invoke("ActivarCubo",0.1f);

    }
}
