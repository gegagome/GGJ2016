using UnityEngine;
using System.Collections;

public class SpawnSystem : GGJBehaviour {
    public int MaxDifficulty;
    public float SpawnTimer;

    private float timer;
    const int DefaultTimer = 2;
    public GameObject[] obstacleList;
    //public int[] zRange = {0, 3, 6};

    void Start()
    {
        SpawnTimer = DefaultTimer;
    }

    void Update()
    {
        //Debug.Log("Timer: " + timer);
        timer += Time.deltaTime;
        if (timer >= SpawnTimer)
        {
            timer = 0;
            SpawnObstacle();
        }
    }

    void StartLevel()
    {
        
    }

    public void SpawnObstacle()
    {
        GameObject currentObstacle = obstacleList[Random.Range(0, obstacleList.Length)];
        /* Determines Difficult of the interval of spawned objects
            while (currentObstacle.GetComponent<LaneableObject>() != null)
            {
                currentObstacle = obstacleList[Random.Range(0, obstacleList.Length)];
            }
        */
        if (Utilities.hasMatchingTag(GGJTag.RedBull, currentObstacle))
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(Random.Range(-3, 3) - 10, 7, 0), Quaternion.identity);
            spawnedObstacle.GetComponent<LaneChanger>().SetLane(Random.Range(1, 4));
        }
        else if (Utilities.hasMatchingTag(GGJTag.Event, currentObstacle))
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(Random.Range(-3, 3) - 10, 2, 0), Quaternion.identity);
        }
        else
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(Random.Range(-3, 3) - 10, 2, 0), Quaternion.identity);
            spawnedObstacle.GetComponent<LaneChanger>().SetLane(Random.Range(1, 4));
        }
    }

}
