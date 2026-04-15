using UnityEngine;
using System.Collections.Generic;
using JetBrains.Annotations;

public class SpawnObject : MonoBehaviour
{

    [SerializeField] private GameObject _GameObjectName;
    [SerializeField] private List<Transform> _GameObjectSpawnLocation = new List<Transform>();

    private void OnTriggerEnter2D(Collider2D collision)
    {//this is for a trigger
        if (collision.tag == "Player")
        {
           
                foreach (Transform location in _GameObjectSpawnLocation)
                {
                    Instantiate(_GameObjectName, location.position, location.rotation);
                    Debug.Log("spawned");
                }

        }
    }
    

    
  
}
