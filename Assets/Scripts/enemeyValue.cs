using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemeyValue : MonoBehaviour
{
    public float moveSpeed = 4f;

    [SerializeField] private bool moveLeft; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft)
        {
            Vector3 temp = transform.position;
            temp.x -= moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            transform.position = temp;
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bounce")
        {
            moveLeft = !moveLeft;
        }
    }
}
