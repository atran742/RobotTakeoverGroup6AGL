using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{

    public Text scoreText;

    public static int score = 0;

    public static void addPoints(int points)
    {
        score+=points;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString() +" dollars stolen";
    }
}
