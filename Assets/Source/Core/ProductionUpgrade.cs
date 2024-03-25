using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Core
{
    public class ProductionUpgrade : MonoBehaviour
    {
        private Button _button;
        [SerializeField] private GameResource _gameResource;
        private float _buttonCooldown = 0.1f;
        private TMP_Text _buttonText;
        private ObservableInt _productionLevel;

        public void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Upgrade);
            _buttonText = _button.transform.GetComponentInChildren<TMP_Text>();
            _productionLevel = ResourceProductionAmountsBank.GetProductionAmount(_gameResource);
            _buttonText.text = $"{_gameResource.ToString()} (Уровень {_productionLevel.Value})";
        }

        public void Upgrade()
        {
            ResourceProductionAmountsBank.UpgradeProductionAmount(_gameResource, new ObservableInt(1));
            _button.interactable = false;
            Invoke("ReactivateButton", _buttonCooldown);
            _buttonText.text = $"{_gameResource.ToString()} (Уровень {_productionLevel.Value})";
        }

        private void ReactivateButton()
        {
            _button.interactable = true;
        }
    }
}