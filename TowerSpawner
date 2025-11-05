using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab; // koppel hier je prefab in de Inspector
    [SerializeField] private float spawnRange = 10f; // hoe ver rondom (0,0,0) je mag spawnen

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Linkermuisklik
        {
            Vector3 randomPosition = GetRandomPosition();
            SpawnTower(randomPosition);
        }
    }

    private void SpawnTower(Vector3 position)
    {
        Instantiate(towerPrefab, position, Quaternion.identity);
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-spawnRange, spawnRange);
        float z = Random.Range(-spawnRange, spawnRange);
        return new Vector3(x, 0, z); // Y=0 zodat toren op de grond staat
    }
}
