using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penalty : MonoBehaviour
{
    public PointManager PointManager;

    public void GetPoint(int point)
    {
        PointManager.Point -= point;
    }
}
