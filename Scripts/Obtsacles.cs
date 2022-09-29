using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Obtsacles : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        transform.position = SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 SpawnObstacle()
    {
        return new Vector3(8.5f,4.2f);
    }


}
