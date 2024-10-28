using TMPro;
using UnityEngine;

public class MyBeautifullCanvasHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _monBeauText;
    //[SerializeField] Button _onClick;
    [SerializeField] InputCounterHandler _counter;

    //private void Update()
    //{
    //    _monBeauText.SetText($"{_counter}");
    //}

    private void OnEnable()
    {
        _counter.OnKeyDown += OnKeyDownEventHandler;
    }
    private void OnDisable()
    {
        _counter.OnKeyDown -= OnKeyDownEventHandler;
    }

    private void OnKeyDownEventHandler(object sender, CountEventArgs arg)
    {
        SetText($"je suis a : {arg.count}");
    }

    public void SetText(string text)
    {

        _monBeauText.text = text;
    }
    //public void DebugText() => Debug.Log("tu as appeler" + _monBeauText);
}
