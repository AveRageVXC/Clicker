using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Core
{
    public class ShopSceneLoader : MonoBehaviour
    {
        [SerializeField] private Button _loadShopButton;

        private void Awake()
        {
            _loadShopButton = GetComponent<Button>();
            _loadShopButton.onClick.AddListener(LoadShopScene);
        }

        public void LoadShopScene()
        {
            SceneManager.LoadScene("Shop");
        }
    }
}