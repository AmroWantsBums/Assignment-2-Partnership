using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneSupport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0.004f, 0); 
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -0.004f, 0);
        }
    }
}
