using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodhacking : MonoBehaviour
{
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            points.AddPoints(10);
        }
    }
}
