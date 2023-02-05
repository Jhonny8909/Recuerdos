using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{

    public Rigidbody2D rb;

    public Animator animacion;

    public bool facingR=true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0.1 || rb.velocity.x < -0.1 || rb.velocity.y > 0.1 || rb.velocity.y < -0.1)
        {
            animacion.SetBool("Mov", true);
        }
        else
        {
            animacion.SetBool("Mov", false);
        }

        if(rb.velocity.x > 0.1 && !facingR)
        {
            Flip();
        }
        else if(rb.velocity.x < -0.1 && facingR)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingR = !facingR;
        transform.Rotate(new Vector3(0, 180, 0));
    }
}
