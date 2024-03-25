using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding: MonoBehaviour
    {
        [SerializeField] private GameResource _gameResource;
        private const float BaseProductionTime = 1.1f;
        private float _productionTime = BaseProductionTime;
        private int _productionAmount;
        private Button _button;
        private Slider _slider;
        public void Awake()
        {
            _productionAmount = ResourceProductionAmounts.GetProductionAmount(_gameResource);
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Produce);
            _slider = _button.transform.GetComponentInChildren<Slider>();
            _slider.maxValue = BaseProductionTime;
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
            ResourceBank.ChangeResource(_gameResource, _productionAmount);
            _button.interactable = true;
            _slider.value = 0;
        }
    }
}