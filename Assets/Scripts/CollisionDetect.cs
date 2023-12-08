using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collider)
    {
        if(collider.gameObject.tag == "ball")
        {
            //Destroy(this.gameObject);
            rb.velocity = Vector3.up * 8f;
        }
        Debug.Log(collider.gameObject.name);
    }
}
