using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class GravityLock : MonoBehaviour
{
    [SerializeField] private GravitySwitch _gravityLock;
    private bool _locked = false;
    //techniqally didn't program it yet so do thaaat (gravitylock)
      
    void Start()
    {
        _gravityLock = FindAnyObjectByType<GravitySwitch>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {//this is for a trigger
        if (collision.tag == "Player")
        {
            _locked = true;
        }
          
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _locked = false;
        }
    }
    public bool lockGravity()
    {
        if (_locked)
        {
            return true;
        }
        else 
        {
            return false;
        }
            
    }
    
}
