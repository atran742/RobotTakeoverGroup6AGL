using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 1f;

    public string sceneName;

    private void FixedUpdate()
    {
        Vector2 temp = transform.position;

        if (Input.GetAxis("Horizontal") > 0)
        {
            temp.x += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            temp.x -= moveSpeed *Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            temp.y += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            temp.y -= moveSpeed *Time.deltaTime;
        }
        
        transform.position = temp;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
