using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;
    private float _spawnRangeX = 20f;
    private float _spawnPosZ = 40f;
    private float _sideSpawnMinZ = -0.5f;
    private float _sideSpawnMaxZ = 15f;
    private float _sideSpawnX = 22f;

    private float startDelay = 2f;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), startDelay, spawnInterval);
        InvokeRepeating(nameof(SpawnLeftAnimal), startDelay, spawnInterval);
        InvokeRepeating(nameof(SpawnRightAnimal), startDelay, spawnInterval);
    }

    void Spawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
        int animalIndex = Random.Range(0, _animalPrefabs.Length);
        Vector3 animalRotation = new Vector3(0, 180, 0);
        Instantiate(_animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(animalRotation));
    }


    void SpawnLeftAnimal()
    {
        Vector3 spawnPos = new Vector3(-_sideSpawnX, 0, Random.Range(_sideSpawnMinZ, _sideSpawnMaxZ));
        int animalIndex = Random.Range(0, _animalPrefabs.Length);
        Vector3 animalRotation = new Vector3(0, 90, 0);
        Instantiate(_animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(animalRotation));
    }

    void SpawnRightAnimal()
    {
        Vector3 spawnPos = new Vector3(_sideSpawnX, 0, Random.Range(_sideSpawnMinZ, _sideSpawnMaxZ));
        int animalIndex = Random.Range(0, _animalPrefabs.Length);
        Vector3 animalRotation = new Vector3(0, -90, 0);
        Instantiate(_animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(animalRotation));
    }
}
