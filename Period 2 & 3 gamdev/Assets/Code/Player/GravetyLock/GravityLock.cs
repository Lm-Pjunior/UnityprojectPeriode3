using JetBrains.Annotations;
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
        else
        {
            _locked = false;
        }
    }   
    public bool lockGravity()
    {
        if (_locked)
        {
            return _locked;
        }
        return false;
    }
    
}
