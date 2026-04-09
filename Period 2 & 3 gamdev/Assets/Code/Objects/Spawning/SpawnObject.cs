using UnityEngine;
using System.Collections.Generic;

public class SpawnObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    // Update is called once per frame
    void Update()
    {
        
    }


    
    [SerializeField] private GameObject _GameObjectName;
    [SerializeField] private List<Transform> _GOSpawnLocation = new List<Transform>();


    public void Spawn()
    {
        foreach (Transform location in _GOSpawnLocation)
        {
            Instantiate(_GameObjectName, location.position, location.rotation);
        }
    }
    
  
}
