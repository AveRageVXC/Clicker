using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding: MonoBehaviour
    {
        [SerializeField] private GameResource _gameResource;
        private int _productionAmount;
        private Button _button;
        public void Awake()
        {
            _productionAmount = 1;
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Produce);
        }
        
        public void Produce()
        {
            ResourceBank.ChangeResource(_gameResource, _productionAmount);
        }
    }
}