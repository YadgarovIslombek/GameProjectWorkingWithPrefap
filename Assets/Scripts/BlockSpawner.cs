using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSppawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public float spawnTime;
    void Start()
    {
       InvokeRepeating("createSpanwBlock",0,spawnTime);
    }

    // Update is called once per frame
    void createSpanwBlock()
    {
           GameObject block = Instantiate(blockPrefab,transform.position,transform.rotation)as GameObject;
    }
}
