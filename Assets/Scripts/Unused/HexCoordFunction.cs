using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class HexCoordFunction : Unit
{
    protected override void Definition() //The method to set what our node will be doing.
    {
    }

    public int x;
    public int y;
    public int z;

    public int GetZcoord (int x, int y)
    {
        z = -x - y;
        return z;
    }
    
}
