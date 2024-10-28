using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class SliderBarre : MonoBehaviour
{
    [SerializeField] private float _number;
    [SerializeField] private Slider _barrete; 

    private void Update()
    {
        _number = _barrete.value;
    }
}
