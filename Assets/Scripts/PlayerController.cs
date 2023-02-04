using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [Header("Movement Variables")]
    private Rigidbody2D _rb;
    private Vector2 moveVector;
    public float moveSpeed;

    private void Awake()
    {
        //Cuando inicie la escena el script mandara a llamar al rb y a la gravedad del rb y se definiran en las variables
        _rb = GetComponent<Rigidbody2D>();

   

        //Aqui asigno los valores a velocidad y salto desde el objeto
        moveSpeed = 10;

       

    }
    public void OnWalk(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(moveVector.x * moveSpeed, _rb.velocity.y);
        _rb.velocity = new Vector2(_rb.velocity.x, moveVector.y * moveSpeed);



    }

}
