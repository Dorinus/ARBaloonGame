using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Camera arCamera;
    public float maxSpawnTimer = 3.0f;

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

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-5.0f,8.0f),Random.Range(-3.0f,3.0f), Random.Range(-5.0f, 8.0f));


        int randomBaloonIndex = Random.Range(0,baloons.Length);
        //Instantiate(baloons[randomBaloonIndex], spawnPoints[randomSpawnPointsIndex].position, Quaternion.identity);
        Instantiate(baloons[randomBaloonIndex], randomSpawnPosition, Quaternion.identity);
        StartCoroutine(StartSpawning());
    }

}
