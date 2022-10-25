using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : Food
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        foodName = "Bread";
        foodValue = 25;
    }

    public override void Update()
    {
        base.Update();

        if(pointsGiven)
        {
            Debug.Log("Game win called from bread.");
            GameManager.instance.GameWin();
            Destroy(this);
        }
    }
}
