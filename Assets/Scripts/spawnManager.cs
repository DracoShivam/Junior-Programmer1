using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float leftBound = -0.9f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnfunc", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
    void Spawnfunc()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
