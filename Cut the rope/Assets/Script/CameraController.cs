using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform candy;


    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(candy.position.x, candy.position.y, transform.position.z);
    }
}
