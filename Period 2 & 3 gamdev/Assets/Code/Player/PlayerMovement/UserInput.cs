using UnityEngine;

public class UserInput : MonoBehaviour
{
    private MovementSystem _playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    void Start()
    {
        _playerMovement = GetComponent<MovementSystem>();
        if (_playerMovement != null) _playerMovement.Awaken();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //delta time thingy has to be added to the original code and keep make the rest of it too D:
        // it's something like this: transform.position += (new Vector3(0,1,0); * Time.deltaTime * _speed)
        // if(Input.GetKey(KeyCode.A)){ body.linearVelocityX = -5; }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _playerMovement.Movement();
           // Debug.Log("movementsystem is active");


        }


        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Gravity works");

        }

       
        //currently doesn't activate the jumping
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jumping works");
            _playerMovement.jump();
        }

    }
    
}


