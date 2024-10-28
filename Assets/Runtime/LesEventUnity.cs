using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LesEventUnity : MonoBehaviour
{
    public UnityEvent<int> OnKeyDown;
    private int _count;
    private float _timeSinceLastIncrement;
    [SerializeField] float incrementDelay = 1f;

    private void Update()
    {


        if (Input.GetKey(KeyCode.Space)) {
            _timeSinceLastIncrement += Time.deltaTime;
            if (_timeSinceLastIncrement >= incrementDelay)
            {
                _count++;
                OnKeyDown.Invoke(_count);
                _timeSinceLastIncrement = 0f;
            } 
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _count++;
            OnKeyDown.Invoke(_count);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _timeSinceLastIncrement = 0f;
        }
    }
}
