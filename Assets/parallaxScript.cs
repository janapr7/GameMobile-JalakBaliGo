using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxScript : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

        //  transform.position = new Vector2(transform.position.x, transform.position.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        // transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);

        if (temp > startpos + length)
        {
            startpos += length;
        }

        else if (temp < startpos - length)
        {
            startpos -= length;
        }
        

        
    }
}
