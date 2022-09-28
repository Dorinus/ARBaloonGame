using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Camera arCamera;
    public float maxSpawnTimer = 3.0f;

    public Transform[] spawnPoints;
    public GameObject[] baloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.0f,this.maxSpawnTimer));

        Vector3 randomSPawnPosition = new Vector3(Random.Range(-5.0f,6.0f),Random.Range(-3.0f,3.0f), Random.Range(-5.0f, 6.0f));


        int randomBaloonIndex = Random.Range(0,baloons.Length);
        int randomSpawnPointsIndex = Random.Range(0,spawnPoints.Length);
        //Instantiate(baloons[randomBaloonIndex], spawnPoints[randomSpawnPointsIndex].position, Quaternion.identity);
        Instantiate(baloons[randomBaloonIndex], randomSPawnPosition, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }

}
