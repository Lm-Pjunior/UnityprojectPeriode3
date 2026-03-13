using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementSystem : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _jumpForce = 26f;

    private bool _grounded =true;
    private Rigidbody2D _body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awaken()
    {
        _body = GetComponent<Rigidbody2D>();
    }


    public void Movement() //movementsystem with fixedupdate which fixes it per frame so that deltatime isn't neccesary.
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        _body.linearVelocity = new Vector2(HorizontalInput * _speed, _body.linearVelocity.y);

        if (HorizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if (HorizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

  

        public void jump()
    {
        Collision2D collision = new Collision2D();
        if (collision.gameObject.CompareTag("grounded"))
        {

            _grounded = true;
        }
        if (_grounded)
        {
            _body.linearVelocity = new Vector2(_body.linearVelocity.x, _jumpForce);
            _grounded = false;
            Debug.Log("jumping!");
        }

      }
     public void grounded()
    {
        _grounded = true;
    }
    
    }
      //ask Jamiro for help

    
  


    


