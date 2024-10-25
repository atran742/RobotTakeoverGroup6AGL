using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerVault : MonoBehaviour
{
    public static GameManagerVault instance;
    public Vector2 playerInitialPosition;
    private GameObject[] enemies;
    private GameObject player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemey");
        player = GameObject.FindGameObjectWithTag("player");
    }

    public void PlayerReachedGoal(string endScene)
    {
        SceneManager.LoadScene(endScene);

    }

    public void PlayerDied()
    {
        Time.timeScale = 0f;

        StartCoroutine(restartGame());
    }

    IEnumerator restartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
