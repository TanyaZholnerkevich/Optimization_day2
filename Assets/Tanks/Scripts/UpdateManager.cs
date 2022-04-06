using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : MonoBehaviour
{
    public IUpdate[] updates;
    private static int nextUpdate;
    private TankAIBenchmark tankAIBenchmark;

    private void Awake()
    {
        tankAIBenchmark = GetComponent<TankAIBenchmark>();
    }

    private void Start()
    {
        var size = tankAIBenchmark.numberOfTanks;
        updates = new IUpdate[size];
        nextUpdate = 0;
    }

    private void Update()
    {
        foreach (var update in updates)
        {
            if (update != null)
            {
                update.NewUpdate();
            }
        }
    }

    public void AddUpdate(IUpdate iUpdate)
    {
        updates[nextUpdate++] = iUpdate;
    }

    public void RemoveUpdate(IUpdate iUpdate)
    {
        for (int i = 0; i < updates.Length; i++)
        {
            if (updates[i] == iUpdate)
            {
                updates = null;
            }
        }
    }
}

public interface IUpdate
{
    void NewUpdate();
}