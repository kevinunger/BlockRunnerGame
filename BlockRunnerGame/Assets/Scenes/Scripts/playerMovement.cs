using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb_player;
    public playerCollision playerCollision;

    public float forwardForce = 500f;
    public float sidewaysForce = 100f;


    public CharacterController controller;
    private float canJump = 0f;

    Vector3 velocity;
    float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb_player.useGravity = true;                                           // Debug.Log("Hello World");
        //rb_player.AddForce(0, 200, 500);

    }

    // Update is called once per frame
    void FixedUpdate()                                    // FixUpdate für physics
    {
        rb_player.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime Zeit: zeit seit letztem frame 



        if (Input.GetKey("d")) {

            rb_player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
            


        }

        if (Input.GetKey("a"))
        {

            rb_player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);



        }




        if (rb_player.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
            


        }




        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {

            velocity = rb_player.velocity;
            velocity.y = jumpSpeed;
            rb_player.velocity = velocity;
            canJump = Time.time + 1.5f;    // whatever time a jump takes
            rb_player.AddForce(Vector3.up * 1000);
        }


    }

    void Update()
    {



    }


    void keyManager()
    {






    }




}
