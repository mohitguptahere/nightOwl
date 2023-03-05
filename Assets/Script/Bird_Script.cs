using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D myRigidbody;
    public float flap;

    public LogicManager logic;
    public bool birdisALive = true;
    


    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdisALive ==true)
        {
            myRigidbody.velocity = Vector2.up * flap;
        }

        if(transform.position.y>12 ||transform.position.y<-12)
        {
            logic.gameOver();
            birdisALive = false;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisALive = false;
        
    }
}
