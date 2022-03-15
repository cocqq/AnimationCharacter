using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawn : MonoBehaviour
{
    public GameObject[] obj;
    public int maxObject = 500;
    private int dis = 10;
    private int minPosition;
    // public float currentObject;
    // public GameObject player;
    void Start()
    {
        for(int i = 0; i <= maxObject; i++)
        {
          Spawn();  
        }
      
    }
    void Spawn()
    {
        // float dis = Vector3.Distance(transform.position, player.transform.position);

        // if (dis >= 10)
        // {
        minPosition += dis;
        float spawnUpX = Random.Range( minPosition, 500);
        float spawnDownX = Random.Range (-minPosition, -500);
        float spawnUpZ = Random.Range( minPosition, 500);
        float spawnDownZ = Random.Range (-minPosition, -500);
    
        int ramdomIndex = Random.Range(0, obj.Length);

        // Vector3 ramdomSpawnPosition = new Vector3(Random.Range(spawnDown, spawnUp), 1, Random.Range( spawnDown , spawnUp ));  
        Vector3 ramdomposition = new Vector3( Random.Range(spawnDownX,spawnUpX), 0, Random.Range(spawnDownZ,spawnUpZ) );
        Instantiate(obj[ramdomIndex], ramdomposition , Quaternion.identity);
        
        // }
    }
}