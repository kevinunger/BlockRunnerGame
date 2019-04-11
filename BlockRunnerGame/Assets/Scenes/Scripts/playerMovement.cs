using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerMovement : MonoBehaviour
{







    private string backKey = "s"; private bool backKeyDown;
    private string leftKey = "a"; private bool leftKeyDown;
    private string rightKey = "d";private bool rightKeyDown;
    private string jumpKey = "KeyCode.Space"; private bool jumpKeyDown;



    public float canJump = 0f;
    public float jumpFrequency = 1.5f;
    public float jumpPower = 1000;

    public Rigidbody rb_player;

    public playerCollision playerCollision;

    public float forwardForce = 1000 ; //8000
    public float sidewaysForce = 120f;




    public CharacterController controller;


    private float canBack = 0f;
    private float backFrequency = 2f;

    Vector3 velocityX;
    Vector3 velocityY;
    Vector3 velocityZ;
    float jumpSpeed;
    float backSpeed;

    // public GameObject JumpBar;
    public Slider JumpBar;





    public bool gettingBack = false;

    //Debug
    public Text speedText;

    //Debug





// Start is called before the first frame update
    void Start()
    {
        JumpBar = GameObject.Find("JumpBar").GetComponent<Slider>();
        //
        //Time.timeScale = 0.1F;
        //
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

  //      Debug.Log("canJump: "+  canJump);
        
   //     Debug.Log("Time.time:" + Time.time);

   //     Debug.Log("DIFF: " +(jumpFrequency - (canJump - Time.time))/jumpFrequency );


        
            if (jumpKeyDown && Time.time > canJump )
        {
            
            JumpBar.value = 0;
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
        { jumpKeyDown = true;  }




        JumpBar.value += 0.01F;
            //jumpFrequency - (canJump - Time.time) / jumpFrequency;


    }



    void keyManager()
    {






    }




}
