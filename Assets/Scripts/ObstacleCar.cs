using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCar : MonoBehaviour
{   

   private void Update() {
       transform.Translate(Vector3.forward*10*Time.deltaTime);
   }
  
}
