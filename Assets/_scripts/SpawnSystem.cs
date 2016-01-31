using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnSystem : GGJBehaviour {
    public int MaxDifficulty;
    public float SpawnTimer;
    private float timer;
    private float gameTimer;
    public List<GameObject> obstacleList;
    //public int[] zRange = {0, 3, 6};
    public GameObject brownBull;
    public GameObject redBull;
    public GameObject yellowBull;
    public GameObject blueBull;
    public GameObject fence;
    public GameObject tripleBull;

    public GameObject healthPickup;
    public GameObject coinPickup;
    public GameObject goal;

    public GameObject player;

    public bool victory = false;

	public static Level levelReference;
	protected override void OnStart()
    {
        //GGJBehaviourStart();
		if (levelReference == null) { //for debug
			levelReference = new Level ();
		}
        levelReference.LevelLengthInTime = 25;
        SpawnTimer = levelReference.SpawnTimeInterval;
        initializeObstacleList();
    }

    void Update()
    {
        //Debug.Log("Timer: " + timer);
        timer += Time.deltaTime;
        gameTimer += Time.deltaTime;
        if (timer >= SpawnTimer && !victory)
        {
            timer = 0;
            SpawnObstacle();
        }
        if (gameTimer >= levelReference.LevelLengthInTime && !victory)
        {
            Debug.Log("Victory!");
            victory = true;
            GameObject endGoal = (GameObject)GameObject.Instantiate(goal, new Vector3(player.transform.position.x + 40f, 2, 0), Quaternion.identity);
        }
        //player.GetComponent<Rigidbody>().velocity = new Vector3(10, 0, 0);
    }

    void initializeObstacleList()
    {
        
        //Debug.Log("Probability: " + levelReference.BrownBullChance + " || Obstacle: " + brownBull);
        addObstacles(levelReference.BlueBullChance, blueBull);
        addObstacles(levelReference.BrownBullChance, brownBull);
        addObstacles(levelReference.RedEventChance, redBull);
        addObstacles(levelReference.YellowEventChance, yellowBull);
        addObstacles(levelReference.TripleBullEventChance, tripleBull);
        addObstacles(levelReference.OrangeBullChance, fence);
    }

    void addObstacles(float probability, GameObject obstacle)
    {
        //Debug.Log("Probability: " + probability + " || Obstacle: " + obstacle);
        for (int i = 0; i < probability; i++)
        {
            if (obstacle != null)
            {
                obstacleList.Add(obstacle);
            } else
            {
                obstacleList.Add(brownBull);
            }
        }
    }

    public void SpawnObstacle()
    {
        GameObject currentObstacle = obstacleList[Random.Range(0, obstacleList.Count)];
        /* Determines Difficult of the interval of spawned objects
            while (currentObstacle.GetComponent<LaneableObject>() != null)
            {
                currentObstacle = obstacleList[Random.Range(0, obstacleList.Length)];
            }
        */
        if (Utilities.hasMatchingTag(GGJTag.RedBull, currentObstacle))
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(player.transform.position.x  - 15, 5, 0), Quaternion.identity);
            spawnedObstacle.GetComponent<LaneChanger>().SetLane(Random.Range(1, 4));
            //spawnedObstacle.transform.Rotate(new Vector2(0, 0));
        }
        else if (Utilities.hasMatchingTag(GGJTag.Event, currentObstacle))
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(player.transform.position.x - 15, 0, 0), Quaternion.identity);
        }
        else
        {
            GameObject spawnedObstacle = (GameObject)GameObject.Instantiate(currentObstacle, new Vector3(player.transform.position.x - 15, 0, 0), Quaternion.identity);
            spawnedObstacle.GetComponent<LaneChanger>().SetLane(Random.Range(1, 4));
            //spawnedObstacle.transform.Rotate(new Vector2(0, 0));
        }
    }

}
