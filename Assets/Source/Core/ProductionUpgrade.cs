using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionUpgrade : MonoBehaviour
    {
        private Button _button;
        [SerializeField] private GameResource _gameResource;
        private float _buttonCooldown = 2.0f; // Set the cooldown duration here

        public void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Upgrade);
        }

        public void Upgrade()
        {
            ResourceProductionAmounts.UpgradeProductionAmount(_gameResource, 1);
            _button.interactable = false;
            Invoke("ReactivateButton", _buttonCooldown);
        }

        private void ReactivateButton()
        {
            _button.interactable = true;
        }
    }
}