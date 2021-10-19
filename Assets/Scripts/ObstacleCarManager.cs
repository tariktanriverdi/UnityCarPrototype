using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCarManager : MonoBehaviour
{

    public ObstacleCar CarPrefab;
    public List<Transform> spawnPosition;
    private float nextActionTime = 0.0f;
    public float period = 0.5f;
    private void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;

            InitCar();
        }


    }
    public void InitCar()
    {
        ObstacleCar oc = Instantiate(CarPrefab, spawnPosition[Random.Range(0, 2)].position, Quaternion.identity) as ObstacleCar;
        oc.transform.rotation=Quaternion.Euler(new Vector3(0,180,0));

    }
}
