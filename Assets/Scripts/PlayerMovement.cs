using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float movementSpeed;
    private PlayerMovement instance;
    public Animator myAnim;

    private bool isMoving = false;
    public AudioSource footsteps;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;    
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        footsteps = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * movementSpeed;

        myAnim.SetFloat("moveX", rb.velocity.x);
        myAnim.SetFloat("moveY", rb.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
        
        if (rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            isMoving = true;
        }
        else isMoving = false;

        if (isMoving)
        {
            if (!footsteps.isPlaying)
            {
                footsteps.Play();
            }
        }
        else footsteps.Stop();
       
        
        
    }

}
