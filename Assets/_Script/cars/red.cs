using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : Car
{
    // Start is called before the first frame update
    public override void DisplayText()
    {
        info.text = "Color: Red";
    }
}
