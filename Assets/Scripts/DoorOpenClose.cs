using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("OpenClose");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
