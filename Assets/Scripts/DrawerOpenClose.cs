using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpenClose : MonoBehaviour
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

    // void Update()
    // {
        // if (Input.GetKeyDown(KeyCode.O))
        // {
            // animator.SetTrigger("OpenClose");
        // }
    // }
}
