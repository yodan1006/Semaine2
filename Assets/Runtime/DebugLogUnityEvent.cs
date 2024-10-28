using UnityEngine;

public class DebugLogUnityEvent : MonoBehaviour
{
    [SerializeField] LesEventUnity counter;
    private void OnEnable()
    {
        counter.OnKeyDown.AddListener(OnkeyDownHandler);
    }

    private void OnDisable()
    {
        counter.OnKeyDown.RemoveListener(OnkeyDownHandler);
    }

    void OnkeyDownHandler(int value)
    {
        Text($"je suis a : {value}");
    }
    void Text(string text)
    {
        Debug.Log(text);
    }
}
