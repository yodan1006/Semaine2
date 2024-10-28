using System;
using UnityEngine;

public class InputCounterHandler : MonoBehaviour
{
    public EventHandler<CountEventArgs> OnKeyDown;
    private int _count;
    private float _timeSinceLastIncrement;
    [SerializeField] float incrementDelay = 1f;

    private void Update()
    {
        _timeSinceLastIncrement += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && _timeSinceLastIncrement >= incrementDelay)
        {
            _count++;
            OnKeyDown.Invoke(this, new CountEventArgs() { count = _count});
            _timeSinceLastIncrement = 0f;
        }
    }

}

public class CountEventArgs
{
    public int count;
}