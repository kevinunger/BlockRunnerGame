using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb_player;
    public playerCollision playerCollision;

    public float forwardForce = 8000f; //8000
    public float sidewaysForce = 120f;


    public CharacterController controller;
    private float canJump = 0f;
    private float canBack = 0f;

    Vector3 velocityY;
    Vector3 velocityZ;
    float jumpSpeed;
    float backSpeed;

    public bool gettingBack = false; 

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

            velocityY = rb_player.velocity;
            velocityY.y = jumpSpeed;
            rb_player.velocity = velocityY;
            canJump = Time.time + 1.5f;    // whatever time a jump takes
            rb_player.AddForce(Vector3.up * 1000);
        }
        
        
        if (Input.GetKeyDown("s") && Time.time > canBack && gettingBack == false)
        {
            gettingBack = true; 
            velocityZ = rb_player.velocity;
            velocityZ.z = backSpeed;
            rb_player.velocity = velocityZ;
            canBack = Time.time + 2f;    // whatever time a jump takes
            //rb_player.AddForce(Vector3.back);
           // forwardForce = 2000f;
            Debug.Log(velocityZ.z);

        }





        else
        {

         //  forwardForce = 8000f;
            //gettingBack = false;
         //   Debug.Log(forwardForce);
            

        }


        Debug.Log(gettingBack);

    }

    void Update()
    {



    }


    void keyManager()
    {






    }




}
