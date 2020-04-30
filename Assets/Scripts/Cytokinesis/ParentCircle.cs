using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCircle : MonoBehaviour
{
    public GameObject[] current = new GameObject[4];
    public StopRotation childCircle;
    public int i = 0;
    public Vector3 localSpawnCoordinates = Vector3.zero;
    public GameObject circle;
    public GameObject itemToSpawn;
    public string nameOfItemToDestroy;


    // Start is called before the first frame update
    void Start()
    {
        childCircle = GetComponentInChildren<StopRotation>();
        childCircle.minRotationValue = 270;
        childCircle.maxRotationValue = 360;
    
    }

    // Update is called once per frame
    void Update()
    {
        if (childCircle.completed)
        {
            Destroy(circle);
            if (i < 3)
            {

                childCircle.completed = false;
                Debug.Log(i);
                circle = Instantiate(current[i + 1], transform.TransformPoint(localSpawnCoordinates), Quaternion.identity) as GameObject;
                circle.transform.parent = this.transform;
                circle.transform.Rotate(0f, 120f, 0f, Space.Self);
                childCircle = circle.GetComponentInChildren<StopRotation>();
                i++;
                updateRange();
            }
            else {
                GameObject newObj = Instantiate(itemToSpawn, transform.TransformPoint(localSpawnCoordinates), Quaternion.identity) as GameObject;
                //I'm hardcoding this right now because I officially do not care anymore and I'm tired. -- JEANE
                newObj.transform.Rotate(0f,-25f,0f,Space.Self);
                newObj.transform.position=new Vector3(2,1.5f,-2.5f);
                Object.Destroy(GameObject.Find(nameOfItemToDestroy));
                Object.Destroy(gameObject);
            }
        }
        
    }

    void updateRange()
    {
        if (i == 1) 
        {
;           childCircle.minRotationValue = 270;
            childCircle.maxRotationValue = 315;
        } else if (i == 2)
        {
            childCircle.minRotationValue = 270;
            childCircle.maxRotationValue = 292.5f;
        } else if (i == 3)
        {
            childCircle.minRotationValue = 270;
            childCircle.maxRotationValue = 281.25f;
        }
    }
}
