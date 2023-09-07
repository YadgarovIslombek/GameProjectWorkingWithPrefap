using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(car != null){

        
        if(Vector3.Distance(car.transform.position,transform.position)< 1.5f){
            Destroy(car);
        }
        } 
        
    }
}
