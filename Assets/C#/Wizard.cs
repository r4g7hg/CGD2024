using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject fireballPrefab;

    float castTimer = 3;
   
    
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
             {
            transform.position = transform.position + Vector3.up *0.02f;
             }
            if (Input.GetKey(KeyCode.A))
             {
            transform.position = transform.position + Vector3.left * 0.02f;
             }
            if (Input.GetKey(KeyCode.S))
             {
            transform.position = transform.position + Vector3.down * 0.02f;
             }
            if (Input.GetKey(KeyCode.D))
             {
            transform.position = transform.position + Vector3.right * 0.02f;
             }
        castTimer -= Time.deltaTime;
        if (Input .GetKeyDown(KeyCode.Space)&& castTimer <= 0)
        {
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<fireball>().direction = movement;
            castTimer = 3;
        }
    }
}
