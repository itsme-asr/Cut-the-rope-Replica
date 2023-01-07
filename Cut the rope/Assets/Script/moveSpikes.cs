using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSpikes : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWayPointIndex = 0;
    [SerializeField] private float platformSpeed = 2f;

    void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex == wayPoints.Length)
            {
                currentWayPointIndex = 0;
            }

        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * platformSpeed);


    }
}
