using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(-5,Random.Range(-1f,0.7f),0);
            timer = 0;
            Destroy(newpipe,7.0f);
        }
    }
}
