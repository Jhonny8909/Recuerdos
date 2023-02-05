using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minijuego : MonoBehaviour
{
    [SerializeField] private float tiempoEntreStop;
    [SerializeField] private float tiempoSigStop;
    public fondoMov vel;
    public Vector2 velmovFondo1;
    public Vector2 velmovFondo2;

    public fondoMov fondomov;

    public Animator animacion;

    public GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (tiempoSigStop > 0)
            {
                tiempoSigStop -= Time.deltaTime;
            }
            if (tiempoSigStop <= 0)
            {
                
                tiempoSigStop = tiempoEntreStop;
            fondomov.enabled = false;
            animacion.SetBool("Stop",true);
            game.SetActive(true);
            }

        
    }

    public void ButonReset()
    {
        fondomov.enabled = true;
        animacion.SetBool("Stop", false);
        game.SetActive(false);
        tiempoSigStop = tiempoEntreStop;
    }
}
