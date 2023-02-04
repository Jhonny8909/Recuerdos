using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public CuadradosSimonDice[] cubos;
    public List<int> ListaAleatoria = new List<int>();

    public bool ListaLlena;
    public bool turnoPC;
    public bool turnoJug;

    public int Contador;
    public int ContadorJug;
    public int NivelActual;

    [Range(0.1f, 2f)]
    public float Velocidad;

    private void Start()
    {
        LlenarListaAleatoria();
        turnoPC = true;
        Invoke("turnopC", 0.5f);
    }
    void LlenarListaAleatoria()
    {
        for (int i=0; i <= 1000; i++)
        {
            ListaAleatoria.Add(Random.Range(0, 3));
        }
        ListaLlena = true;
    }

    public void CambiarEstado()
    {
        if (turnoPC)
        {
            turnoPC = false;
            turnoJug = true;
        }
        else
        {
            turnoPC = true;
            turnoJug = false;
            Contador = 0;
            ContadorJug = 0;
            Invoke("turnopC", 1.2f);
        }
    }

    void turnopC()
    {
        if (ListaLlena && turnoPC)
        {
            cubos [ListaAleatoria[Contador]].ActivarCubo();

            if (Contador >= NivelActual)
            {
                NivelActual++;
                CambiarEstado();
            }
            else
            {
                Contador++;
            }
            Invoke("turnopC", Velocidad);
        }
    }

    public void ClickUsuario(int idCube)
    {
        if (idCube != ListaAleatoria[ContadorJug])
        {
            print("game over");
            return;
        }
        if (ContadorJug == Contador)
        {
            CambiarEstado();
        }
        else
        {
            ContadorJug++;
        }
    }
   
}
