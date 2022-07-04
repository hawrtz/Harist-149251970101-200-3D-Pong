using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public int speed;

    private Rigidbody rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }

    private Vector3 GetInput()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        else if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        return Vector3.zero;
    }

   

}
