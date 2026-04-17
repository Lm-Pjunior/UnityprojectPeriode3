using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapHit : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {//this is for a trigger
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(_sceneName);
        }
       
    }
}
