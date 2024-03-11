using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public Transform Parent;
    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.Find("Obstacles").GetComponent<Transform>();
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(4f);
        int RandomNumber = Random.Range(-3,1);
        Debug.Log(RandomNumber);
        Vector2 SpawnLocation = new Vector2(0, RandomNumber);
        Instantiate(ObstaclePrefab, SpawnLocation, Quaternion.identity, Parent);
        StartCoroutine(SpawnObstacle());
    }
}
