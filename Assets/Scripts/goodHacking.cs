using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodHacking : MonoBehaviour
{
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "player")
        {
            points.addPoints(10);
        }
    }
}
