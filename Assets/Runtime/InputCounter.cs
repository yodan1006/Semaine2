using System;
using UnityEngine;

public class InputCounter : MonoBehaviour
{
    public  event Action<int> _onKeyDown;
    private int _count;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            _count++; 
            _onKeyDown?.Invoke(_count);
        }
    }

}
