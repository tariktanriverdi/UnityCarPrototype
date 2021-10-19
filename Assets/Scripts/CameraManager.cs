using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject MainCame;
    private Vector3 distance;
    private void Awake() {
        distance=player.transform.position-MainCame.transform.position;
    }
    
   
    private void LateUpdate() {
        this.MainCame.transform.position=player.transform.position-distance;
        
    }
}
