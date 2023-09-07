using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveBlocks : MonoBehaviour
{
    public Transform targetPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,20);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,targetPosition.position,Time.deltaTime*speed);
        
    }
}
