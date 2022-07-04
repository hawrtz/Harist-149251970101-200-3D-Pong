using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController2 : MonoBehaviour
{
    public Collider ball;
    public bool isP3;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision == ball)
        {
            if (isP3)
            {
                manager.AddP3Score(1);
            }
            else
            {
                manager.AddP4Score(1);
            }

        }

    }


}