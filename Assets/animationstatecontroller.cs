using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationstatecontroller : MonoBehaviour
{
    Animator animator;
    int iswalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       // iswalkingHash = Animator.StringtoHash("iswalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isrunning = animator.GetBool("isrunning");
        bool iswalking = animator.GetBool("iswalking");
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        
        if (!iswalking && forwardPressed)
        {
            animator.SetBool("iswalking", true);
        }
        if (iswalking && !forwardPressed)
        { 
            animator.SetBool("iswalking", false);
        }

        if (!isrunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isrunning", true);
        }

        if (isrunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isrunning", false);
        }
    }
}
