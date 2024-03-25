using System;
using System.Net.Mime;
using Core;
using TMPro;
using UnityEngine;

public class ResourceVisual: MonoBehaviour
{
    [SerializeField] private GameResource gameResource;
    
    private ObservableInt _currentCounter;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _currentCounter = ResourceBank.GetResource(gameResource);
        SetText(_currentCounter);
        _currentCounter.OnValueChanged = SetText;
    }

    public void SetText(ObservableInt value)
    {
        _text.text = value.Value.ToString();
    }
    
    public void SetText(int value)
    {
        _text.text = value.ToString();
    }
}