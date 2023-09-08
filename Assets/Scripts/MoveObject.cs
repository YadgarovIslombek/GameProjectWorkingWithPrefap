using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject moveObject;
    public Transform targetPosition;
    public float speed;
 

    

    void Update()
    {
        moveObject.transform.position = Vector3.MoveTowards(moveObject.transform.position, targetPosition.position, Time.deltaTime * speed);
            moveObject.transform.LookAt(targetPosition);
        // if(Input.GetKey(KeyCode.Space)){
        // if (Vector3.Distance(moveObject.transform.position, targetPosition.position) < 0.5f)
        // {
        //     Destroy(moveObject, 2);
        // }
        // else
        // {
        //     // Move the object towards the target
        //     moveObject.transform.position = Vector3.MoveTowards(moveObject.transform.position, targetPosition.position, Time.deltaTime * speed);
        //     moveObject.transform.LookAt(targetPosition);
        

        // }
        // }
         
        
    }
}