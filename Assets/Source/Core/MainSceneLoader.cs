using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Core
{
    public class MainSceneLoader : MonoBehaviour
    {
        [SerializeField] private Button _loadShopButton;

        private void Awake()
        {
            _loadShopButton = GetComponent<Button>();
            _loadShopButton.onClick.AddListener(LoadMainScene);
        }

        public void LoadMainScene()
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}