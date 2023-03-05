using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawnscript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pipes;
    public float spawnRate=2;
    public float timer=0;
    //public float hightOffset = 5;

    public float lowRange;
    public float highRange;



    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            Spawn();
            timer = 0;

        }

    
    }

    void Spawn()
    {
        

        Instantiate(pipes, transform.position, transform.rotation);
        transform.position = new Vector3(transform.position.x, Random.Range(lowRange, highRange), transform.position.z);
    }
}
