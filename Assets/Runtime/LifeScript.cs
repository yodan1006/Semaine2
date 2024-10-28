using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour
{
    [SerializeField] float _maxHP;
    [SerializeField] float _currentHP;
    [SerializeField] Image _life;

    private void Start()
    {
        _currentHP = _maxHP;    
    }

    private void Update()
    {
        _life.fillAmount = _currentHP / _maxHP;
    }

    //void LifeCurrent()
    //{
    //    _life.fillAmount = _currentHP / _maxHP;
    //    //Color redLife = Color.Lerp(Color.red, Color.green, _currentHP / _maxHP);
    //    //_life.color = redLife;
    //}
}
