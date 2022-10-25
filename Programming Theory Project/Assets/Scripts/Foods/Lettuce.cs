using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lettuce : Food
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        foodName = "Lettuce";
        foodValue = 5;
    }
}
