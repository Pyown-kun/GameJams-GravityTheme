using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text TimeText;
    public PointManager PointManager;

    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject nextLevel;

    [SerializeField] private int maxTime;
    private float time;

    private void Start()
    {
        time = maxTime;
    }

    private void Update()
    {
        time -= Time.deltaTime;

        int timeInt = Convert.ToInt32(time);

        TimeText.text = timeInt.ToString();

        if (timeInt <= 0)
        {
            Time.timeScale = 0;

            if (PointManager.Point >= 100)
            {
                nextLevel.SetActive(true);
            }
            else
            {
                gameOver.SetActive(true);
            }
        }
    }
}
