using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ham : Food
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        foodName = "Ham";
        foodValue = 6;
    }
}