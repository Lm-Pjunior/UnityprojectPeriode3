using UnityEngine;

public class GravitySwitch : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GravityLock _permission;

    private float setGravity;

    private void Start()
    {
        _permission = FindAnyObjectByType<GravityLock>();

    }
    public void gravitySwitch()
    {
        if (_permission.lockGravity())
        {
            _rb.gravityScale *= -1;
        }
        
        //_setGravity = _setGravity; //it doesn't catch this command line
    }


    public void massLoss()
    {
        _rb.mass = 100;
    }

    public void massNorm()
    {
        _rb.mass = 1;
    }








    void Update()
    {
        
    }
}
