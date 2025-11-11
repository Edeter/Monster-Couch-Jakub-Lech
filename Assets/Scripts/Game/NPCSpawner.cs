using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField] NPCController template;
    [SerializeField]  PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SpawnNPCs();
    }

    void SpawnNPCs()
    {
        for(int i = 0; i < 1000; i++)
        {
            Vector3 randomPosition = new(Random.Range(template.character.xLimit.x, template.character.xLimit.y), Random.Range(template.character.yLimit.x, template.character.yLimit.y), 0);
            var instance = Instantiate(template, randomPosition, Quaternion.identity, transform);
            instance.Target = playerController.gameObject;
        }
    }
}
