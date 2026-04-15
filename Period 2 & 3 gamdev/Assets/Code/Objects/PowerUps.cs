using UnityEngine;
using System.Collections;
public class PowerUps : MonoBehaviour
{
    [SerializeField] private MovementSystem _movementSystem;
    [SerializeField] private bool _boost;
    [SerializeField] private float _boostPower;
    [SerializeField] private float _boostDuration;

    private void Start()
    {
        _movementSystem = FindAnyObjectByType<MovementSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {//this is for a trigger
        if (collision.tag == "Player")
        {
            StartCoroutine(Boosted(_boostDuration));
        }
    }


    IEnumerator Boosted(float boostDuration)
    //this bit of code is a pain
    //basicly this happends outside of the normal counting system as it isn't per frame but jsut per second :D
    //you put a timer in and whatever you put above the yield return WaitForSeconds will happen for a set period of time
    {

        if (_boost)
        {
            _movementSystem.Speed *= _boostPower;
        }
        else
        {
            _movementSystem.Speed /= _boostPower;
        }

        yield return new WaitForSeconds(boostDuration);

        if (_boost)
        {
            _movementSystem.Speed *= _boostPower;
        }
        else
        {
            _movementSystem.Speed *= _boostPower;
        }
    }
}