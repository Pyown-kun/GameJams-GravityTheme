using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text PointText;
    public int Point;

    private void Update()
    {
        PointText.text = Point.ToString();
    }

}
