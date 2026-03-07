using UnityEngine;

public class UserInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //delta time thingy has to be added to the original code and keep make the rest of it too D:
        // it's something like this: transform.position += (new Vector3(0,1,0); * Time.deltaTime * _speed)
        // if(Input.GetKey(KeyCode.A)){ body.linearVelocityX = -5; }

        if (Input.GetKey(KeyCode.A))
        {

        }

        if (Input.GetKey(KeyCode.D))
        {

        }

        if (Input.GetKey(KeyCode.W))
        {

        }
    }
}
