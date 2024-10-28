using UnityEngine;

public class DebugTestHandler : MonoBehaviour
{
    [SerializeField] InputCounterHandler counter;
    private void OnEnable()
    {
        counter.OnKeyDown += OnkeyDownHandler;
    }

    private void OnDisable()
    {
        counter.OnKeyDown -= OnkeyDownHandler;
    }

    void OnkeyDownHandler(object sender, CountEventArgs arg)
    {
        Text($"je suis a : {arg.count}");
    }
    void Text(string text)
    {
        Debug.Log(text);
    }
}
