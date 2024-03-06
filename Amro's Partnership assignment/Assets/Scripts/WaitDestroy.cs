using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator ObjectDestroy()
    {
        yield return new WaitForSeconds(20f);
        Destroy(gameObject);
    }
}
