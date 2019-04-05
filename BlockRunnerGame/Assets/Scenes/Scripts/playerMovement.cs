using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb_player;

    public float forwardForce = 500f;
    public float sidewaysForce = 100f;
    

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



    }

    void Update()
    {



    }



}
