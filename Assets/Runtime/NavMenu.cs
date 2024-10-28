using UnityEngine;
using UnityEngine.UI;

public class NavMenu : MonoBehaviour
{
    [SerializeField] RectTransform _imageModif;
    [SerializeField] Vector2 _normalSize = new Vector2(100, 100);
    [SerializeField] Vector2 _hoverSize = new Vector2(150, 100);
    private Image _image;

    private void Start()
    {
       _image = GetComponent<Image>();
        _imageModif.sizeDelta = _normalSize;
    }

    public void OnPointer()
    {
        _imageModif.sizeDelta = _hoverSize;
    }

    public void ExitPointer()
    {
        _imageModif.sizeDelta = _normalSize;
    }

}
