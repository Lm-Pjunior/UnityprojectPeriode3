using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementSystem : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }
    

    
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

  

     
   
}
//ask Jamiro for help
//Scripting: GetComponent<Rigidbody2D>().gravityScale = 0.5f; for the gravity switch








