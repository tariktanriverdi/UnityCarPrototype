using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   [SerializeField]
   private float speed=10;
   [SerializeField]
   private float RotateSpeed=20;
   [SerializeField]
    void Update()
    {
      float Vertical=Input.GetAxis("Vertical");
      float Horizontal=Input.GetAxis("Horizontal");
      transform.Translate(Vector3.forward*Time.deltaTime*speed*Vertical); 
      transform.Rotate(Vector3.up,Time.deltaTime*speed*Horizontal*RotateSpeed*Vertical); 
    
    }
}
