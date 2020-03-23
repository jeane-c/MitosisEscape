using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetOpenClose : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        Debug.Log("Hovering");
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
