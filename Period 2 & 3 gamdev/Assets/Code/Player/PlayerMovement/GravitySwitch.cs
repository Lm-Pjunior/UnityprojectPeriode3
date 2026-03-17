using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    void Start()
    {
        
    }

    public void gravitySwitch()
    {

       GetComponent<Rigidbody2D>().gravityScale = -1f;

    }











    void Update()
    {
        
    }
}
