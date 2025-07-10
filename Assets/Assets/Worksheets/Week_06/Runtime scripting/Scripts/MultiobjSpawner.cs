using UnityEngine;

public class MultiobjSpawner : MonoBehaviour
{
    public GameObject prefab; 
    public int asteroidnum = 3; // Number of asteroids to spawn
    public Vector2 spawnRangeX = new Vector2(-5f, 5f); // X pos range
    public Vector2 spawnRangeY = new Vector2(-3f, 3f); // Y pos range
    public Vector2 destroyRange = new Vector2(0f, 5f); //destroy random range
    private Rigidbody2D rb;

    void Start()
    {
        //soawn in the asteroids
        SpawnAsteroids();
        DestroyObjectDelayed();
    }

    void SpawnAsteroids()
    {
        for (int i = 0; i < asteroidnum; i++)
        {
            Vector3 randomPosition = new Vector3(
                    Random.Range(spawnRangeX.x, spawnRangeX.y),
                    Random.Range(spawnRangeY.x, spawnRangeY.y),
                    0f);

            GameObject asteroid = Instantiate(prefab, randomPosition, Quaternion.identity);
            rb = asteroid.AddComponent<Rigidbody2D>();

        }


    }

    void DestroyObjectDelayed()
    {
        Destroy(prefab, Random.Range(0f, 5f));
    }
}


