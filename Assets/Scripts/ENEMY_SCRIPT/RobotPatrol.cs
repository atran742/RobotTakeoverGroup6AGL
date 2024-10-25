using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        //Check to see if we reached the patrol point
        if(Vector3.Distance (transform.position, currentPatrolPoint.position) < .1f)
        {
            //We reached patrol point, now we have to go to the next one
            if(currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            }
            //Check if we got to the end, then go back to the beginning
            else
            {
                currentPatrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[currentPatrolIndex];
        }

        //Rotate and face the direction of the next patrol point
        Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
        //Find the rotation angle in degrees that we need to face towards
        float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;
        //Made the rotation needed for the next patrol point
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        //Apply rotation to transform the object's rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180f);
    }
}
