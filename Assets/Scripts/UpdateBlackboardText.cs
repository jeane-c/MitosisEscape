using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBlackboardText : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    public int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {
            count = count + 1;
            if (count >= material.Length)
            {
                count = 0;
                rend.sharedMaterial = material[count];
            }
            else
            {
                rend.sharedMaterial = material[count];
            }
        }
              
    }


}
