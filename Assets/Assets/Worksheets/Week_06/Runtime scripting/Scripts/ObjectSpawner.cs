using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
        public GameObject AsteroidPrefab;

        void Start()
        {
            GameObject newAsteroid = Instantiate(AsteroidPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
