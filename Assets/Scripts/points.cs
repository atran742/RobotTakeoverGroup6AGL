using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    // Start is called before the first frame update

    public static int pointTotal = 0 ;
    public Text pointText;
    void Start()
    {
        pointText.text = pointTotal.ToString() + " dollars stolen";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddPoints(int num)
    {
        pointTotal += num; 
    }
}
