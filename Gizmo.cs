using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour
{
    public float gizmoSize = 0.3f;
    public Color gizmoColor = Color.yellow;
    public float speed = 5;
  

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }

    void Start()
    {
       
    }
    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        float turnup = Input.GetAxis("Vertical");
        if (transform.rotation.x > 20) 
        {
            turnup = 0f;
        }
        if(transform.rotation.x < -20)
        {
            turnup = 0f;
        }

        transform.Rotate(-1 * 0.5f * turnup, -1 * turn * speed , 0f);

    }
}
