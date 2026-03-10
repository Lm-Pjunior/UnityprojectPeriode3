using System.Runtime.CompilerServices;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _jumpForce = 26f;

    private bool _grounded;
    private Rigidbody2D _body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awaken()
    {
       _body = GetComponent<Rigidbody2D>();
    }

    public void LMovement()
    {
        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

    public void RMovement()
    {
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

    }
    // it's something like this: transform.position += (new Vector3(0,1,0); * Time.deltaTime * _speed)
    // if(Input.GetKey(KeyCode.A)){ body.linearVelocityX = -5; }

    // Update is called once per frame
    void Update()
    {
        
    }
}
