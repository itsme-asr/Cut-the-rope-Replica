using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public HingeJoint2D hook;

    public GameObject linkPrefab;
    public int links = 7;

    void Start()
    {
        generateRope();

    }

    private void generateRope()
    {
        for (int i = 0; i < links; i++)
        {
            Instantiate(linkPrefab, transform);

        }


    }

}


