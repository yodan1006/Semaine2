using TMPro;
using UnityEngine;

public class MyBeautifullCanvas : MonoBehaviour
{
    [SerializeField] string _textview;
    [SerializeField] TextMeshProUGUI _monBeauText;

    private void Start()
    {
        //_monBeauText.text = _textview;
        SetText(_textview);
    }

    public void SetText(string text) => _monBeauText.text = text;
}
