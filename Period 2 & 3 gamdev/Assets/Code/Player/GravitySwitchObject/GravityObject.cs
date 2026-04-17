using System.Collections.Generic;
using UnityEngine;

public class GravityObject : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private List<GameObject> _gameObjects; 
    public void gravityControl()
    {
        foreach (GameObject interactionBox in _gameObjects)
        {
            _rb.gravityScale *= -1;
        }
        
        
    }
    
}
