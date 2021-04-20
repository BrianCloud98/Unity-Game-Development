using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    public GameObject car;
    float nextTimeToSpawn = 0f;

    private void Update()
    {
        
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        Instantiate(car);
    }
}
