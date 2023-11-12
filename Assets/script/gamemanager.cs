using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    [SerialzeField] private GameObject Box;
    [SerialzeField] private float maxX;
    [SerialzeField] private Tranform spawnPoint;
    [SerialzeField] private float spawnRate;

    private bool isGameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBox()
    {
        Vector2 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(Box,)
    }
}
