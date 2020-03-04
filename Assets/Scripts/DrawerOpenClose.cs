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

    private void OnMouseDown()
    {
        animator.SetTrigger("OpenClose");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("OpenClose");
        }
    }
}
