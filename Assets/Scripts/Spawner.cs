using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fishPrefabs; // Array de prefabs de peixes
    public GameObject[] trashPrefabs; // Array de prefabs de resíduos
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnRandomObject", spawnInterval, spawnInterval);
    }

    void SpawnRandomObject()
    {
        int randomIndex = Random.Range(0, transform.childCount); // Escolhe um dos pontos de geração
        Transform spawnPoint = transform.GetChild(randomIndex);

        // Decide se deve gerar um peixe ou resíduo
        bool spawnFish = Random.value > 0.5f;
        GameObject[] prefabs = spawnFish ? fishPrefabs : trashPrefabs;

        int prefabIndex = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[prefabIndex], spawnPoint.position, Quaternion.identity);
    }
}
