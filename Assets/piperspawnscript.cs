using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piperspawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 2;
    private float timer = 0;
     public float heightOfSet = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnTime)
        {
        timer += Time.deltaTime;
        }
        else
        {
        spawnpipe();    
        timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowstPoint = transform.position.y - heightOfSet;
        float highestPoint = transform.position.y + heightOfSet;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowstPoint,highestPoint), 0), transform.rotation);
    }
}
