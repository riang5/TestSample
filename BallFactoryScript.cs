using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall", 0f, 5f);
    }

    void SpawnBall()
    {
        Instantiate(Ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
