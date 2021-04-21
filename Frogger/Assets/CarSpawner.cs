using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public Car[] cars;
    public Car car;
    public Transform[] spawnPoints;
    float spawnDelay = 1.4f;

    private void Start()
    {
        InvokeRepeating("SpawnCar", 0f, spawnDelay);
    }

    void SpawnCar()
    {
        car = cars[Random.Range(0, cars.Length)];
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];
        switch (randomIndex)
        {
            case 0:
                car.speed = 4f;
                break;
            case 1:
                car.speed = 7f;
                break;
            case 2:
                car.speed = 6f;
                break;
            case 3:
                car.speed = 5f;
                break;
        }
        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
