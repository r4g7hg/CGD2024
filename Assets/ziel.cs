using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnColisionEnter2D(Collision collision2D)
    {
        Destroy(gameObject);
    }
}
