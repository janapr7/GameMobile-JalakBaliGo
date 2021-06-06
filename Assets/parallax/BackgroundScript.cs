using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xVelocity, yVelocity;

    // Start is called before the first frame update
    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    
    void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);
        
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
        
    }
}
