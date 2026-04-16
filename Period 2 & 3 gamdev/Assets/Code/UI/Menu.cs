using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//UnityEngine.UI allowes me acces to the Button class so I don't have to make a serialize field for an object
//and i don't have to use the getcomponent function
public  class Menu : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    [SerializeField] private Button _button;
    private void Start()
    { //AddListerner is basicly do this function
        _button.onClick.AddListener(PickScene); 
    }
    private void PickScene()
    {
        SceneManager.LoadScene(_sceneName);
    }

  
}
