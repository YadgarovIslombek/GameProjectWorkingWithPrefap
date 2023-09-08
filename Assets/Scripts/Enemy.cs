using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
      car = GameObject.Find("car");  
    }

    // Update is called once per frame
    void Update()
    {
        if(car){

        
        if(Vector3.Distance(car.transform.position,transform.position)< 1f){
            Destroy(car);
            Application.LoadLevel(1);
        }
        } 
        
    }
}
