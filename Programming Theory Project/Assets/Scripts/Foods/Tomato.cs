using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : Food
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        foodName = "Tomato";
        foodValue = 15;
    }
}
