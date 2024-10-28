using UnityEngine;

public class DebugTest : MonoBehaviour
{
    [SerializeField] InputCounter counter;
    private void OnEnable()
    {
        counter._onKeyDown += OnkeyDownHandler;
    }

    private void OnDisable()
    {
        counter._onKeyDown -= OnkeyDownHandler;
    }

    void OnkeyDownHandler(int value)
    {
        Text($"{value}");
    }
    void Text(string text)
    {
        UnityEngine.Debug.Log(text);
    }
}
