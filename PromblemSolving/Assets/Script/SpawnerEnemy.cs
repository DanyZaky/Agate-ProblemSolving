using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject spawnArea;

    void Start()
    {
        spawnEnemy();
    }

    void spawnEnemy()
    {
        int randomItem = 0;
        GameObject toSpawn;
        PolygonCollider2D c = spawnArea.GetComponent<PolygonCollider2D>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);

            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    void destroyEnemy()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            Destroy(o);
        }
    }
}
