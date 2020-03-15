using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz;
    Rigidbody2D fizik;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        
        transform.position += new Vector3(yatay * hiz * Time.deltaTime, 0);
        
        
    }
}
