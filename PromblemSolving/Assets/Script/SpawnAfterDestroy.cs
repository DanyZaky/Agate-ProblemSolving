using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAfterDestroy : MonoBehaviour
{
    [SerializeField] SpawnerEnemy spawnerEnemy;
    [SerializeField] MoveInputTouch moveInput;
    public GameObject enemyPrefabs;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (moveInput.gameOver == false)
            {
                StartCoroutine(spawnAfterDestroy());
            }
        }
    }

    IEnumerator spawnAfterDestroy()
    {
        yield return new WaitForSeconds(3f);

        GameObject toSpawn;
        PolygonCollider2D c = spawnerEnemy.spawnArea.GetComponent<PolygonCollider2D>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < 1; i++)
        {
            toSpawn = enemyPrefabs;

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);

            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
}
