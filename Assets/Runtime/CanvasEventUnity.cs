using TMPro;
using UnityEngine;

public class CanvasEventUnity : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _monBeauText;
    [SerializeField] LesEventUnity _counter;

    private void OnEnable()
    {
        _counter.OnKeyDown.AddListener(OnKeyDownEventHandler);
    }
    private void OnDisable()
    {
        _counter.OnKeyDown.RemoveListener(OnKeyDownEventHandler);
    }

    private void OnKeyDownEventHandler(int value)
    {
        SetText($"je suis a : {value}");
    }

    public void SetText(string text)
    {

        _monBeauText.text = text;
    }
}