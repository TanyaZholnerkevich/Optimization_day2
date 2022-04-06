using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TankAIBenchmark : MonoBehaviour
{
    [SerializeField] private UpdateManager updateManager;
    private Transform[] tanks;

    public int numberOfTanks;
    public GameObject tankPrefab;
    void Start()
    {
        tanks = new Transform[numberOfTanks];
        for (int i = 0; i < numberOfTanks; i++)
        {
            var spawnPosition = new Vector3(Random.Range(-50,50), 0, Random.Range(-50,50));
            tanks[i] = Instantiate(tankPrefab, spawnPosition, Quaternion.identity).transform;
            
            var tankController = tanks[i].GetComponent<IUpdate>();
            updateManager.AddUpdate(tankController);
        }
    }
}