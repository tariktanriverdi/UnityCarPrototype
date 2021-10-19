using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
   public float speed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Rotate(Vector3.forward*Time.deltaTime*speed*10*horizontalInput*verticalInput);
    }
}
