using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCUD : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
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

        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }
        return Vector3.zero;
    }

}
