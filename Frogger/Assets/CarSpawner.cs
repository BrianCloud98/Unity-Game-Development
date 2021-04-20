using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] cars;
    public GameObject car;
    public Transform[] spawnPoints;

    private void Start()
    {
        InvokeRepeating("SpawnCar", 0f, 2f);
    }

    private void Update()
    {
        
    }

    void SpawnCar()
    {
        car = cars[Random.Range(0, cars.Length)];
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
