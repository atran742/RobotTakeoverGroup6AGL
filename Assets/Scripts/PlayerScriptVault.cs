using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movSpeed = 8;
    Rigidbody2D rb;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2 (inputX, inputY);
        move.Normalize();

        rb.velocity = move * movSpeed;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "enemey")
        {
            GameManagerVault.instance.PlayerDied();
        }

        if (target.tag == "Goal")
        {
            GameManagerVault.instance.PlayerReachedGoal(sceneName);
        }
    }


}
