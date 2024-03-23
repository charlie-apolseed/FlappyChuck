using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public PipeScript pipeScript;
    public float spawnRate = 4;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnRate)
        {
            spawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void spawnPipe()
    {
        Instantiate(pipe, transform.position + Vector3.up * Random.Range(-5, 5), transform.rotation);
    }
   
}
