using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : Food
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        foodName = "Cheese";
        foodValue = 10;
    }
}
