    using System.Collections.Generic;
    using UnityEngine;
    using static UnityEditor.FilePathAttribute;

    public class GravityObject : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _gameObjects;
        [SerializeField] private GameObject _GameObjectName;
        [SerializeField] private List<Transform> _GameObjectSpawnLocation = new List<Transform>();

        public void gravityControl()
        {
            foreach (GameObject interactionBox in _gameObjects)
            {
            Rigidbody2D rb = interactionBox.GetComponent<Rigidbody2D>();
            rb.gravityScale *= -1;
                Debug.Log("box interaction");
            }
        }
        public void spawnInteractable()
        {
            foreach (Transform location in _GameObjectSpawnLocation)
            {
                Instantiate(_GameObjectName, location.position, location.rotation);
                Debug.Log("spawned");
            }
        }
 
    }

