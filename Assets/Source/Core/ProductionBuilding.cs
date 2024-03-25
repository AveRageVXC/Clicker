using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding: MonoBehaviour
    {
        [SerializeField] private GameResource _gameResource;
        private const float BaseProductionTime = 1.0f;
        private float _productionTime = BaseProductionTime;
        private ObservableInt _productionAmount;
        private Button _button;
        private Slider _slider;
        private TMP_Text _buttonText;
        private ObservableInt _productionLevel;
        public void Awake()
        {
            _productionAmount = ResourceProductionAmountsBank.GetProductionAmount(_gameResource);
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Produce);
            _slider = _button.transform.GetComponentInChildren<Slider>();
            
            _buttonText = _button.transform.GetComponentInChildren<TMP_Text>();
            _buttonText.text = $"+{_productionAmount}";
            
            _productionTime = BaseProductionTime * (1 - _productionAmount.Value / 100.0f);
            _slider.maxValue = _productionTime;
            _slider.value = 0;
        }
        
        public void Produce()
        {
            _button.interactable = false;
            StartCoroutine(AddResource());
        }
        
        private void Update()
        {
            if (_button.interactable) return;
            _slider.value += Time.deltaTime;
        }

        private IEnumerator AddResource()
        {
            yield return new WaitForSeconds(_productionTime);
            ResourceBank.ChangeResource(_gameResource, _productionAmount.Value);
            _button.interactable = true;
            _slider.value = 0;
        }

    }
}