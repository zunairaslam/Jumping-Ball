using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public List<GameObject> Obstacles;
    private float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        StartCoroutine(SpawnObstacle());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int idex = Random.Range(0, Obstacles.Count);
            Instantiate(Obstacles[idex]);

        }

    }

    public void UpdateScore(int addToScore)
    {
        score += addToScore;
        scoreText.text = "Score: " + score;

    }
}
