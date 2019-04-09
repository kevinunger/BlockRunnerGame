using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{

    private string backKey = "s"; private bool backKeyDown;
    private string leftKey = "a"; private bool leftKeyDown;
    private string rightKey = "d";private bool rightKeyDown;
    private string jumpKey = "KeyCode.Space"; private bool jumpKeyDown;



    private float canJump = 0f;
    private float jumpFrequency = 1.5f;
    public float jumpPower = 1000;

    public Rigidbody rb_player;

    public playerCollision playerCollision;

    public float forwardForce = 6000f; //8000
    public float sidewaysForce = 120f;




    public CharacterController controller;


    private float canBack = 0f;
    private float backFrequency = 2f;

    Vector3 velocityX;
    Vector3 velocityY;
    Vector3 velocityZ;
    float jumpSpeed;
    float backSpeed;

   
   


    public bool gettingBack = false;

    //Debug
    public Text speedText;

    //Debug

        


    // Start is called before the first frame update
    void Start()
    {
        rb_player.useGravity = true;

        // Debug.Log("Hello World");
        //rb_player.AddForce(0, 200, 500);

    }


    // Update is called once per frame
    void FixedUpdate()                                    // FixUpdate für physics
    {



        rb_player.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime Zeit: zeit seit letztem frame 
                     
        if (rightKeyDown)
        {
            rb_player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rightKeyDown = false;
        }

        if (leftKeyDown)
        {
            rb_player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            leftKeyDown = false;
        }
        
     /*   if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {

            velocityY = rb_player.velocity;
            velocityY.y = jumpSpeed;
            rb_player.velocity = velocityY;
            canJump = Time.time + jumpFrequency;    // whatever time a jump takes
            rb_player.AddForce(Vector3.up * 1000);
        }
        */
        if (jumpKeyDown && Time.time > canJump )
        {

            velocityY = rb_player.velocity;
            velocityY.y = jumpSpeed; //jumpSpeed
            rb_player.velocity = velocityY;
            canJump = Time.time + jumpFrequency;    // whatever time a jump takes
            rb_player.AddForce(Vector3.up * jumpPower);
            jumpKeyDown = false;
        }
        else
        {
            jumpKeyDown = false;
        }






        if (backKeyDown && Time.time > canBack && gettingBack == false)
        {
            gettingBack = true;
            velocityZ = rb_player.velocity;
            velocityZ.z = backSpeed;
            rb_player.velocity = velocityZ;
            canBack = Time.time + backFrequency;                        
            backKeyDown = false;                             
                                                             
                                                             

        }





        else
        {

            //  forwardForce = 8000f;
            //gettingBack = false;
            //   Debug.Log(forwardForce);


        }


        //Debug.Log(rb_player.velocity.z);



        if (rb_player.position.y < -3f)
        {
            FindObjectOfType<gameManager>().CompleteLevel();
        }
        
    }

void Update()
    {

        //DEBUG
        speedText.text = rb_player.velocity.z.ToString("0");
        //DEBUG


        if (Input.GetKeyDown(backKey))
        { backKeyDown = true; }

        if (Input.GetKey(leftKey))
        { leftKeyDown = true; }

        if (Input.GetKey(rightKey))
        { rightKeyDown = true; }



        if (Input.GetKeyDown(KeyCode.Space))
        { jumpKeyDown = true;
            //Debug.Log("jumpKey");
           
        }


    }



    void keyManager()
    {






    }




}
