using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int foodValue
    {
        get;
        protected set;
    }

    public string foodName
    {
        get;
        protected set;
    }

    float createdTime;

    Rigidbody rb;
    protected bool pointsGiven = false;

    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        createdTime = Time.time;
    }

    public virtual void Update()
    {
        if (pointsGiven == false)
        {
            if (CheckMoving() == false)
            {
                GameManager.instance.AddPoints(foodValue);
                pointsGiven = true;
            }
        }
    }

    bool CheckMoving()
    {
        if (Time.time - createdTime > 0.2f)
        {
            if (rb.velocity.magnitude < 0.02f)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return true;
        }
    }
}
