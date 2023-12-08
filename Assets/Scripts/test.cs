using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //private int Counter;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        //Counter = 0;
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Counter++;
        //Debug.Log(Counter);
       // if(Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(this.gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
