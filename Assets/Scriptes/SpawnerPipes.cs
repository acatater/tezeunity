using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipes : MonoBehaviour
{
    [SerializeField] private float maxTime = 1;
    [SerializeField] private float height;

    private float timer = 0;

    [SerializeField] GameObject pipe;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 8);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
