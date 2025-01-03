using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int point;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerControls playerControls = collision.gameObject.GetComponent<PlayerControls>();
            playerControls.GetPoint(point);
            Destroy(gameObject);
        } 
        
        if (collision.gameObject.tag == "Penalty")
        {
            Penalty penalty = collision.gameObject.GetComponent<Penalty>();
            penalty.GetPoint(1);
            Destroy(gameObject);
        }   
    }
}
