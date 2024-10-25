using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaultEnter : MonoBehaviour
{
    public GameObject player; 
    public int sceneName;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (Calculator.key)
        {
            if (collision.gameObject.tag == "player")
            {
                SceneManager.LoadScene(sceneName);
                player.SetActive(false);
                points.addPoints(10);
            }
        }
    }
}
