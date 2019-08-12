using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float walkspeed;

    private Rigidbody2D rb;

    private Vector2 newMovement;

    private bool facingRight = true;

    private bool jump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = newMovement;
    }
    public void Move(float direction)
    {
        float currentSpeed = walkspeed;
        newMovement = new Vector2(direction * currentSpeed, rb.velocity.y);

        if(facingRight && direction < 0)
        {
            Flip();
        }
        else if(!facingRight && direction > 0)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }


}
