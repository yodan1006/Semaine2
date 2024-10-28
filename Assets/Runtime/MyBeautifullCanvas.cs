using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MyBeautifullCanvas : MonoBehaviour
{
    [SerializeField] string _textview;
    [SerializeField] TextMeshProUGUI _monBeauText;
    [SerializeField] Button _onClick;

    private void Start()
    {
        //_monBeauText.text = _textview;
        SetText(_textview);
        _onClick.onClick.AddListener(DebugText);
    }

    public void SetText(string text) => _monBeauText.text = text;
    public void DebugText() => Debug.Log("tu as appeler" + _monBeauText);
}
