using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInput : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    private MovementSystem _playerMovement;
    private GravityObject _gravityObject;
   [SerializeField] private GravitySwitch _switchGravity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    void Start()
    {
        _playerMovement = GetComponent<MovementSystem>();
        if (_playerMovement != null) _playerMovement.Awaken();
        _gravityObject = GetComponent<GravityObject>();
        
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



       
        //currently doesn't activate the jumping
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {        
            _switchGravity.massLoss();
        }
        else
        {
            _switchGravity.massNorm();
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            _switchGravity.gravitySwitch();
            _gravityObject.gravityControl();
        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("escape to menu");

            SceneManager.LoadScene(_sceneName);

        }
    }
    
}


