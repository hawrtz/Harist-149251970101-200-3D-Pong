using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isP1;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        
        if(collision == ball)
        {
            if (isP1)
            {
                manager.AddP1Score(1);
            }
            else
            {
                manager.AddP2Score(1);
            }

        }

    }


}