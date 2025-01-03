using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public PointManager PointManager;
    [SerializeField] private float speedMove;

    private bool isMove;
    private InputSystemManager inputSystem;
    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        inputSystem = new InputSystemManager();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputSystem.Enable();
    }

    private void Start()
    {
        inputSystem.Player.Move.performed += _ => IsMoving();
        inputSystem.Player.Move.canceled += _ => NotMoving();
    }

    private void IsMoving()
    {
        isMove = true;
    }
    private void NotMoving()
    {
        isMove = false;
    }

    private void Update()
    {
        if (isMove)
        {
            rb.position -= new Vector2(speedMove * Time.deltaTime, 0);
        }
    }

    public void GetPoint(int pointPlus)
    {
        PointManager.Point += pointPlus;
    }
}
