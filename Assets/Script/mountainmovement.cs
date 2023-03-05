using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mountainmovement : MonoBehaviour
{


    //public float movespeed = 0.1f;

    public Rigidbody2D myrigidbody;
    public float flap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + (Vector3.left*movespeed) * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            myrigidbody.velocity = Vector2.down;
        }
    }
}
