using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject virus;
    float spawnDelay;
    void Update()
    {
        if (spawnDelay < 0)
        {
            virusSpawn();
            spawnDelay = Random.Range(.5f, 1f);
        }

        spawnDelay -= Time.deltaTime;
    }

    void virusSpawn()
    {
        GameObject newVirus = (GameObject)Instantiate(virus);
        newVirus.transform.position = transform.position + new Vector3(Random.Range(-7.5f,7.5f), 0);
        newVirus.transform.rotation = transform.rotation;
    }
}
