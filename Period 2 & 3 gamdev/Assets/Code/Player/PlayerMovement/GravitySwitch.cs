using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    private float setGravity;


    public void gravitySwitch()
    {
        //I should put the gameobject here that i want to chance
        
        _rb.gravityScale *= -1;
        setGravity = _rb.gravityScale;
        //_setGravity = _setGravity; //it doesn't catch this command line
    }


    public void massLoss()
    {
        _rb.mass = 100;
    }

    public void massNorm()
    {
        _rb.mass = 0;
    }








    void Update()
    {
        
    }
}
