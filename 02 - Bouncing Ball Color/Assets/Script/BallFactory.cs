using System.Collections.Generic;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
    private List<GameObject> gameObjects = new List<GameObject>();

    public GameObject prefab;
    
    public float interval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, interval);
    }

    void SpawnObject()
    {
        var vector = new Vector3(0, 0, 0);
        gameObjects.Add(Instantiate(prefab, vector, Quaternion.identity));
        if (gameObjects.Count >= 10)
        {
            CancelInvoke("SpawnObject");
        }

    }

}
