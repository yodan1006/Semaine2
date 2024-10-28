using TMPro;
using UnityEngine;

public class MyBeautifullCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _monBeauText;
    //[SerializeField] Button _onClick;
    [SerializeField] InputCounter _counter;

    //private void Update()
    //{
    //    _monBeauText.SetText($"{_counter}");
    //}

    private void OnEnable()
    {
        _counter._onKeyDown += OnKeyDownEventHandler;   
    }
    private void OnDisable()
    {
        _counter._onKeyDown -= OnKeyDownEventHandler;
    }

    private void OnKeyDownEventHandler(int value)
    {
        SetText(value.ToString());
    }

    public void SetText(string text) {
        
        _monBeauText.text = text; 
    }
    //public void DebugText() => Debug.Log("tu as appeler" + _monBeauText);
}
