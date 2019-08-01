using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //public float speed = 1;
    private float  a, b, c, X, Y, Z, t;
    private GameObject parent;
  
    // Start is called before the first frame update
    void Start()
    {
        X = Random.Range(15f, 25f);
        Y = 0f;
        Z = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(X * Time.deltaTime, Y * Time.deltaTime , Z * Time.deltaTime);

        transform.position -= new Vector3(0f,t, 0f);

        t += 0.00025f;

        if(transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0.15f, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Stick"))
        {
             parent = GameObject.FindWithTag("Gizmo");
           

              a = 1 * Mathf.Cos(-1 * parent.transform.rotation.y * Mathf.PI / 180);
              c = 1 * Mathf.Sin(-1 * parent.transform.rotation.y * Mathf.PI / 180);

              X =-1 * (a * a - c * c) / (c * c + a * a) * 10;
              Z =-1 * (2 * a * c) / (c * c + a * a) * 500;
              Y = parent.transform.rotation.x * 100;
            //Z = parent.transform.position.z ; 
        }
         

    }

}
