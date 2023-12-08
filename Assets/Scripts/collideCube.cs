using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideCube : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * 300);
            //rb.AddForce(Vector3.right * 50);
            //rb.velocity = vector3.forward * 13f;
        }
    }
}
