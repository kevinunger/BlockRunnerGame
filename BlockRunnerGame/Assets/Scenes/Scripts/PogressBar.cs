using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PogressBar : MonoBehaviour
{



    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60, 20);
    public Texture2D emptyTex;
    public Texture2D fullTex;


    




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (FindObjectOfType<playerMovement>().canJump < Time.time)
             barDisplay = Time.time * 0.05f;   // barDisplay = MyControlScript.staticHealth;
    }

}
