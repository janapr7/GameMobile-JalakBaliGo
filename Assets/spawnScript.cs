using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    float time = 0;
    float timer = 3;
    float level = 0;

    public GameObject pipa;

    // Update is called once per frame
    void Update()
    {
        if(time<=0)
        {
            Instantiate(pipa, transform.position, Quaternion.identity);
            time = timer;
            level++;
            if(level==5)
            {
                if(timer>1)
                {
                    timer = timer-0.35f;
                    level = 0;
                }
            }

        }
        else
        {
            time -= Time.deltaTime;

        }
        
    }
}
