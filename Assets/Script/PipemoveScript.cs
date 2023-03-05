using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipemoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed=5;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left*moveSpeed)*Time.deltaTime;

        if(transform.position.x < -25.51)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
