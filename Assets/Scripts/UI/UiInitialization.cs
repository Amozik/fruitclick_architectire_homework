using Data;
using DefaultNamespace.Interfaces;
using UnityEngine;

namespace DefaultNamespace.UI
{
    public class UiInitialization
    {
        private Canvas _canvas;

        private GameObject _endGame;
        
        public UiInitialization(UiConfig config, ICollectableViewModel collectableVM, int livesCount)
        {
            _canvas = Object.FindObjectOfType<Canvas>();
            
            var score = Object.Instantiate(config.score, _canvas.transform);
            score.Initialize(collectableVM);

            var lives = Object.Instantiate(config.lives, _canvas.transform);
            lives.Initialize(collectableVM, livesCount);

            _endGame = Object.Instantiate(config.endGame, _canvas.transform);
            _endGame.SetActive(false);
            collectableVM.OnLivesChange += OnLivesChange;
        }

        private void OnLivesChange(int lives)
        {
            if (lives <= 0)
                _endGame.SetActive(true);
        }
    }
}