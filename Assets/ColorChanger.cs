using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    //bool blue;


    // Use this for initialization
    void Start()
    {
        //blue = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("1"))

           // if (blue)
            {
                 gameObject.GetComponent<Renderer>().material.color = Color.red;
            }

        if (Input.GetKeyDown("2"))

           // if (blue)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown("3"))

          // if (blue)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
     }
}