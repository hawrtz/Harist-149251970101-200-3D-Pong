using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector3 speed;
    public Vector3 resetPosition;
    private Rigidbody rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.z, 2);
    }



}
