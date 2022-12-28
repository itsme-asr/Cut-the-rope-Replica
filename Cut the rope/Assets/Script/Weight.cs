using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    public float distanceFromEnd = .6f;
    public void connectRopeEnd(Rigidbody2D rgb)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = rgb;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceFromEnd);


    }

}
