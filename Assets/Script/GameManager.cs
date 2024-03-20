using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    void Start()
    {
        GameStart();

    }

    void Update() 
    {

    }

     IEnumerator SpawnObstacles()
     {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);
 
            yield return new WaitForSeconds(waitTime);
 
            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
     }

    public void GameStart()
    {
 
        StartCoroutine("SpawnObstacles");
 
    }

    
}